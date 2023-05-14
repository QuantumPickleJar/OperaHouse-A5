using OperaHouse_Assignment5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperaHouse_Assignment5
{
    /// <summary>
    /// Form that allows manipulation of an event's collection of Tickets
    /// </summary>
    public partial class TicketForm : Form
    {
        frmOverview parent;
        private List<Ticket> eventTickets;
        private BindingSource tktBindSrc;

        public TicketForm(List<Ticket> tickets, frmOverview parent)
        {
            this.parent = parent;


            eventTickets = tickets;

            InitializeComponent();

            RefreshTickets();
        }

        private void RefreshTickets()
        {
            tktBindSrc = new BindingSource();
            tktBindSrc.DataSource = eventTickets;
            lstTickets.DataSource = tktBindSrc;
            lstTickets.DisplayMember = "SeatNumber";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            parent.UpdateEventTickets(eventTickets);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string msg = "This  will void any changes made to the tickets.  " +
                "Are you sure this is what you wish to do?";
            DialogResult doDelete = MessageBox.Show(msg, "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (doDelete == DialogResult.No)
                return;
            else
                this.Close();
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTickets.SelectedIndex > -1)
            {
                Ticket selected = (Ticket)lstTickets.SelectedItem;
                txtSeatCode.Text = selected.SeatNumber.ToString();

                // visually represent ticket status via radiobuttons
                _ = selected.Sold ? (rbSold.Checked = true) : (rbNotSold.Checked = true);
            }
        }

        private void rbNotSold_CheckedChanged(object sender, EventArgs e)
        {
             if(lstTickets.SelectedIndex > -1) {
                Ticket selected = (Ticket)lstTickets.SelectedItem;
                selected.Sold = false;

             }
        }

        private void rbSold_CheckedChanged(object sender, EventArgs e)
        {
            if (lstTickets.SelectedIndex > -1)
            {
                Ticket selected = (Ticket)lstTickets.SelectedItem;
                selected.Sold = true;
            }
        }

        private void txtSeatCode_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txtSeatCode_Validating(object sender, CancelEventArgs e)
        {
            // get the currently selected Ticket
            Ticket selected = (Ticket)lstTickets.SelectedItem;
            int index = eventTickets.IndexOf(selected);

            if (!selected.SeatNumber.Equals(txtSeatCode.Text))
            {
                // check to see if another ticket already has this SeatNumber
                if (eventTickets.Any(tkt => tkt.SeatNumber.Equals(txtSeatCode.Text)))
                {
                    MessageBox.Show("This SeatNumber is already in use!", "Warning");
                    return;
                }
                else
                {
                    eventTickets[index].SeatNumber = int.Parse(txtSeatCode.Text);
                    RefreshTickets();
                }
            }
        }

    }
}
