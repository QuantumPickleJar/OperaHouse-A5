using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OperaHouse_Assignment5

{
    public partial class frmOverview : Form
    {
        private List<Event> events, results;
        private List<Stage> stages;
        private List<Performer> performers; // we need to store performers somewhere to be able to sort by them within the drop-down
        private BindingSource perfBind, stageBind; // since multiple controls refer to this collection, make it class-level

        public frmOverview()
        {
            // load from DB 
            performers = EventsDB.PopulatePerfomers();
            events = EventsDB.PopulateEvents();     
            stages = EventsDB.PopulateStages();
            
            perfBind = new BindingSource(performers, "Name");
            stageBind = new BindingSource(stages, "StageName");

            InitializeComponent();
            RefreshEvents();
            RefreshModifiables();
        }
      

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex == -1)
                return;

            // remove the selected event from the list
            Event target = events.Where(ev => ev.Title.Equals(ParseEventDetails())).First();

            if (events.Contains(target))
                events.Remove(target);

            RefreshEvents();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (FieldSafetyCheck())
            {
                // a new event shouldn't have any sold out tickets ideally
                //List<Ticket> _tickets = new List<Ticket>(int.Parse(txtTickets.Text));
                //_tickets.ForEach(t => t.Sold = false);

                Event entry = ParseEventDetails();

                // Warn the user to ensure the event is not an accidental duplicate
                if (events.Contains(entry))
                {
                    string msg = "This Event already exists, are you sure you wish to add this item?";
                    DialogResult isDupe = MessageBox.Show(msg, "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (isDupe == DialogResult.No)
                        return;
                }

                events.Add(entry);
                RefreshEvents();
                // add an event
            }
        }

        private void cbxPerformer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // makes sure that we don't let users hit delete with nothing selected
            if (cbxPerformer.SelectedIndex == -1)
            {
                btnMinus.Enabled = false;
            } else {
                btnMinus.Enabled = true;
                if (chkPerformer.Checked)
                {
                    OverlapFilters();

                    FilterByPerformer();
                }
            }
        }
 
        private void btnTickets_Click(object sender, EventArgs e)
        {
            Event selected = lstEvents.SelectedItem as Event;
            if(selected != null)
            {
                TicketForm ticketForm = new TicketForm(selected.tickets, this);
                ticketForm.Visible = true;
            }
        }
        
        private void frmOverview_Load(object sender, EventArgs e)
        {
            RefreshEvents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Event current = lstEvents.SelectedItem as Event;
            current = events.Where(ev => ev.ID == current.ID).First();
            current.ConcessionSales = chkConcessions.Checked;
            current.Stage = cbxStage.SelectedItem as Stage;
            current.EventTime = dtpEventTime.Value;
            current.Title = txtTitle.Text;
            current.DurationMinutes = int.Parse(txtDuration.Text);
            current.UpdatePrice(double.Parse(txtPrice.Text));
            current.Performer = cbxPerformer.SelectedItem as Performer;


            // if the number of available tickets was changed:
            if (!current.NumAvailableTickets.ToString().Equals(txtTickets.Text))
            {
                int startSeatNum, difference, newTicketCap;
                newTicketCap = int.Parse(txtTickets.Text);
                difference = newTicketCap - current.NumAvailableTickets;
                // if the change is feasible through expansion, go that route
                if(newTicketCap > current.NumAvailableTickets) // or (diff > 0)
                {
                    current.tickets.Capacity = newTicketCap;
                    startSeatNum = current.tickets.Last().SeatNumber;

                    // difference will (in this if block) always be equal to the # of new tickets to add
                    for (int i = difference; i < newTicketCap; i++)
                    {
                        current.tickets.Add(new Ticket(startSeatNum + i, current.Price));
                    }

                }
                // otherwise warn the user of imminent data loss
                else {

                    string msg = "You are about to shrink the ticket pool; this will remove tickets" +
                        $"{Math.Abs(difference)} through {newTicketCap}. \n " +
                        "Are you sure you wish to proceed?";
                    DialogResult choice = MessageBox.Show(msg, "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);;
                    if (choice == DialogResult.No)
                        return;
                    // no else here
                    current.tickets.Capacity = newTicketCap;
                }
            }
            RefreshEvents();
        }

        private void chkConcessions_CheckedChanged(object sender, EventArgs e)
        {
            // if NOT checked, strikethrough the font
            if (!chkConcessions.Checked)
                chkConcessions.Font = new Font(chkConcessions.Font, FontStyle.Strikeout);
            else    // reset the font to regular
            {
                chkConcessions.Font = new Font(chkConcessions.Font, FontStyle.Regular);
                
            }
            chkConcessions.Refresh();

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            events.Sort(new PerformerDateComparer());
            RefreshEvents();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            events.Sort(new TitleComparer());
            RefreshEvents();

        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInputsToDigits(e);
        }

        private void txtTickets_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInputsToDigits(e);
        }

        private void chkOpenShows_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpenShows.Checked)
            {
                if (chkPerformer.Checked)
                {
                    OverlapFilters();
                }
                else
                    FilterOpenShows();
            }
            else
            {
                if (chkPerformer.Checked)
                {
                    FilterByPerformer();
                } else 
                    RefreshEvents();
            }
        }


        private void chkPerformer_CheckedChanged(object sender, EventArgs e)
        {
            bool isFilteredByPerformer = chkPerformer.Checked;
            bool nonNullPerformer = cbxPerfFilter.SelectedIndex > -1;

            // this is a little ugly, but it works as we only have two filter parameters
            if (isFilteredByPerformer)
            {
                cbxPerfFilter.Enabled = true;

                if (nonNullPerformer)
                    FilterByPerformer();
            }
            else // if the checkbox is being unchecked
            {
                cbxPerfFilter.Enabled = false;

                if (chkOpenShows.Checked)
                {
                    FilterOpenShows();
                }
                else
                    RefreshEvents();
            }
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex > -1)
            {
                var selected = lstEvents.SelectedItem as Event;
                chkConcessions.Checked = selected.ConcessionSales;
                btnSave.Enabled = true;
                btnTickets.Enabled = true;
                // RefreshModifiables();
            }
            else
            {
                btnSave.Enabled = false;
                btnTickets.Enabled = false;
            }
        }

        // ******  UTILITY METHODS ******** //

        /// <summary>
        /// Refreshes the modifiable controls on the form
        /// </summary>
        private void RefreshModifiables()
        {
            // regardless of selected items, refresh lists of combo-boxes in case they were modified
            cbxPerformer.SelectedIndex = -1;
            cbxStage.SelectedIndex = -1;

            // if something is selected
            if (lstEvents.SelectedIndex > -1)
            {
                // Bind the comboboxes to class-level binding sources
                cbxPerformer.DataSource = perfBind.DataSource;
                cbxPerformer.DisplayMember = perfBind.DataMember;

                cbxPerfFilter.DataSource = perfBind.DataSource;
                cbxPerfFilter.DisplayMember = perfBind.DataMember;

                cbxStage.DataSource = stageBind.DataSource;
                cbxStage.DisplayMember = stageBind.DataMember;

                // Love when Intellicode suggests syntax you didn't know of!
                Event selected = lstEvents.SelectedItem as Event;

                if (selected != null)
                {
                    txtDuration.Text = selected.DurationMinutes.ToString();
                    txtTickets.Text = selected.NumAvailableTickets.ToString();
                    txtTitle.Text = selected.Title;
                    txtPrice.Text = (selected.Price).ToString();
                    lblID.Text = selected.ID;
                    dtpEventTime.Value = selected.EventTime;
                    cbxPerformer.SelectedItem = selected.Performer;
                    cbxStage.SelectedItem = selected.Stage;
                }
            }
            else
            {
                txtDuration.Text = string.Empty;
                txtTickets.Text = string.Empty;
                txtTitle.Text = string.Empty;
                lblID.Text = string.Empty;
                txtPrice.Text = string.Empty;
                // deselect the combox indices
                cbxPerformer.SelectedIndex = -1;
                cbxStage.SelectedIndex = -1;
                dtpEventTime.Value = DateTime.Today;
            }
        }

        /// <summary>
        /// Reloads the UI for the events; if no List specified it will
        /// default to an unfilitered selection of all Events
        /// </summary>
        private void RefreshEvents(List<Event> query = null)
        {
            // update the listBox compoennt
            BindingSource eventBind = new BindingSource();

            if (query != null) { eventBind.DataSource = query; }
            else { eventBind.DataSource = events; }

            lstEvents.DataSource = eventBind;
            lstEvents.DisplayMember = "Name";
        }


        /// <summary>
        /// Checks all of the modifiable fields, and warns the user of problematic inputs
        /// where applicable via MessageBox.Show().
        /// </summary>
        private bool FieldSafetyCheck()
        {
            string message = "The following fields have invalid inputs:";
            List<String> errors = new List<String>(5);

            if (txtTitle.Text.Equals(string.Empty)) { errors.Add("Title"); }

            if (cbxPerformer.SelectedIndex == -1) { errors.Add("Performer"); }

            if (cbxStage.SelectedIndex == -1) { errors.Add("Stage"); }

            // Finally had a chance to apply the '_' discard operator!
            if (txtDuration.Text == string.Empty || !int.TryParse(txtDuration.Text, out _))
            {
                errors.Add("Duration");
            }
            if (txtTickets.Text == string.Empty || !int.TryParse(txtTickets.Text, out _))
            {
                errors.Add("Ticket Count");
            }
            if (errors.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (string errorMessage in errors)
                {
                    message.Concat(", " + errorMessage);
                }
                MessageBox.Show(message, "Warning");
                return false;
            }
        }


        /// <summary>
        /// Gathers the information from the UI and--if possible--constructs an Event
        /// </summary>
        /// <returns>The event--note there are no safety checks and this may cause strange
        /// behavior</returns>
        private Event ParseEventDetails()
        {
            return new Event(
                                (events.Count() + 1).ToString(),
                                txtTitle.Text,
                                cbxPerformer.SelectedItem as Performer,
                                int.Parse(txtTickets.Text),
                                int.Parse(txtPrice.Text),
                                dtpEventTime.Value,
                                int.Parse(txtDuration.Text),
                                chkConcessions.Checked,
                                cbxStage.SelectedItem as Stage
                            );
        }

        /// <summary>
        /// Updates an events collection of Ticket objects
        /// </summary>
        /// <param name="newTickets">The revised set of Tickets passed from a <b>TicketForm</b></param>
        public void UpdateEventTickets(List<Ticket> newTickets)
        {
            if (lstEvents.SelectedIndex > -1)
            {
                Event current = lstEvents.SelectedItem as Event;
                current = events.Where(ev => ev.ID == current.ID).First();
                //int i = events.IndexOf(current);    
                //events[i].tickets = newTickets;
                current.tickets = newTickets;

                RefreshEvents();
                RefreshModifiables();
            }
        }

        /// <summary>
        /// Helper method that applies both filters to the displayed list of events
        /// </summary>
        private void OverlapFilters()
        {
            // incorporate overlapping filters
            Performer selectedPerf = cbxPerformer.SelectedItem as Performer;
            results = events.Where(ev =>
                ev.Performer == selectedPerf &&
                ev.IsSoldOut == false).ToList();
            RefreshEvents(results);
        }

      
        

        /// <summary>
        /// Ensures that only numbers are entered into the text field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void RestrictInputsToDigits(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// utility method to save a filtered collection of results by their IsSoldOut attribute
        /// and update the visible collection to reflect this new collection
        /// </summary>
        private void FilterByPerformer()
        {
            if (cbxPerformer.SelectedIndex > -1)
            {
                var selected = lstEvents.SelectedItem as Event;
                results = events.Where(ev => ev.Performer.Name.Equals(selected.Performer.Name)).ToList();
                RefreshEvents(results);
            }
        }

        /// <summary>
        /// utility method to save a filtered collection of results by their IsSoldOut attribute
        /// and update the visible collection to reflect this new collection
        /// </summary>
        private void FilterOpenShows()
        {
            results = events.Where(ev => ev.IsSoldOut == false).ToList();
            RefreshEvents(results);
        }
    }
}
