using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OperaHouse_Assignment5

{
    public partial class frmOverview : Form
    {
        private List<Event> events;
        private List<Performer> performers; // we need to store performers somewhere to be able to sort by them within the drop-down
        private BindingSource perfBind; // since multiple controls refer to this collection, make it class-level

        public frmOverview()
        {

            performers = EventsDB.PopulatePerfomers();
            events = EventsDB.PopulateEvents();     // load from DB 

            perfBind = new BindingSource();

            InitializeComponent();
            RefreshEvents();
            RefreshModifiables();
        }

        private void RefreshModifiables()
        {
            // regardless of selected items, refresh lists of combo-boxes in case they were modified
            cbxPerformer.SelectedIndex = -1;
            cbxStage.SelectedIndex = -1;

            // if something is selected
            if (lstEvents.SelectedIndex >= 0)
            {
                // Bind the Event.Performer combobox to class-level var
                perfBind.DataSource = performers;
                cbxPerformer.DataSource = perfBind.DataSource;
                cbxPerformer.DisplayMember = "Name";

                // TODO: populate stage

                // Love when Intellicode suggests syntax you didn't know of!
                Event selected = lstEvents.SelectedItem as Event;

                if (selected != null)
                {
                    txtDuration.Text = selected.DurationMinutes.ToString();
                    txtTickets.Text = selected.NumAvailableTickets.ToString();
                    txtTitle.Text = selected.Title;
                    lblID.Text = selected.ID;
                    dtpEventTime.Value = selected.EventTime;
                    cbxPerformer.SelectedItem = selected.Performer;
                    cbxStage.SelectedItem = selected.Stage;
                }
            }
            else {
                txtDuration.Text = string.Empty;
                txtTickets.Text = string.Empty;
                txtTitle.Text = string.Empty;
                lblID.Text = string.Empty;
                // deselect the combox indices
                cbxPerformer.SelectedIndex = -1;
                cbxStage.SelectedIndex = -1;
                dtpEventTime.Value = DateTime.Today;
            }
        }

        private void RefreshEvents()
        {
            // update the listBox compoennt
            BindingSource eventBind = new BindingSource();
            eventBind.DataSource = events;
            lstEvents.DataSource = eventBind;
            lstEvents.DisplayMember = "Name";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // ????
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            // remove the selected event from the list
            
            // on successful operations, refresh Events
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // return out if nothing is selected
            if (lstEvents.SelectedIndex == 0) 
                return;

            FieldSafetyCheck();
            // add an event
            
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
            
            if(cbxPerformer.SelectedIndex == 0) { errors.Add("Performer"); }
            
            if(cbxStage.SelectedIndex == 0) { errors.Add("Stage"); }

            // Finally had a chance to apply the '_' discard operator!
            if (txtDuration.Text == string.Empty || !int.TryParse(txtDuration.Text, out _))
            {
                errors.Add("Duration");
            }
            if (txtTickets.Text == string.Empty || !int.TryParse(txtTickets.Text, out _))
            {
                errors.Add("Ticket Count");
            }
            if(errors.Count == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(message, "Warning");
                return false;
            }
        }

        private void cbxPerformer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // refresh the filter

            // makes sure that we don't let users hit delete with nothing selected
            if (cbxPerformer.SelectedIndex == 0)
            {
                btnMinus.Enabled = false;
            } else {
                btnMinus.Enabled = true;
            }

            
        }

        private void chkPerformer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPerformer.Checked)
            {
                cbxPerfFilter.Enabled = true;
            }
            else
                cbxPerfFilter.Enabled = false;
        }


        private void chkOpenShows_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshModifiables();
        }
    }
}
