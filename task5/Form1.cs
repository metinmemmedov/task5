

namespace task5
{
    public partial class Form1 : Form
    {
        int duration1, duration2, duration3, duration4, duration5, duration6;
        string client1 = "", client2 = "", client3 = "", client4 = "", client5 = "", client6 = "";

        public Form1()
        {
            InitializeComponent();
        }

        // ================= ROOM 1 =================
        private void button1_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 1?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration1 = time;
                    client1 = textBox1.Text + " - Room 1";
                    listBox1.Items.Add(client1);

                    button1.Enabled = false;
                    button1.BackColor = Color.Red;
                    label1.Text = "Time left: " + duration1;
                    timer1.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration1--;
            label1.Text = "Time left: " + duration1;

            if (duration1 <= 0)
            {
                timer1.Stop();
                button1.Enabled = true;
                button1.BackColor = Color.White;
                label1.Text = "Available";
                listBox1.Items.Remove(client1);
            }
        }

        // ================= ROOM 2 =================
        private void button2_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 2?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration2 = time;
                    client2 = textBox1.Text + " - Room 2";
                    listBox1.Items.Add(client2);

                    button2.Enabled = false;
                    button2.BackColor = Color.Red;
                    label2.Text = "Time left: " + duration2;
                    timer2.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            duration2--;
            label2.Text = "Time left: " + duration2;

            if (duration2 <= 0)
            {
                timer2.Stop();
                button2.Enabled = true;
                button2.BackColor = Color.White;
                label2.Text = "Available";
                listBox1.Items.Remove(client2);
            }
        }

        // ================= ROOM 3 =================
        private void button3_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 3?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration3 = time;
                    client3 = textBox1.Text + " - Room 3";
                    listBox1.Items.Add(client3);

                    button3.Enabled = false;
                    button3.BackColor = Color.Red;
                    label3.Text = "Time left: " + duration3;
                    timer3.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            duration3--;
            label3.Text = "Time left: " + duration3;

            if (duration3 <= 0)
            {
                timer3.Stop();
                button3.Enabled = true;
                button3.BackColor = Color.White;
                label3.Text = "Available";
                listBox1.Items.Remove(client3);
            }
        }

        // ================= ROOM 4 =================
        private void button4_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 4?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration4 = time;
                    client4 = textBox1.Text + " - Room 4";
                    listBox1.Items.Add(client4);

                    button4.Enabled = false;
                    button4.BackColor = Color.Red;
                    label4.Text = "Time left: " + duration4;
                    timer4.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            duration4--;
            label4.Text = "Time left: " + duration4;

            if (duration4 <= 0)
            {
                timer4.Stop();
                button4.Enabled = true;
                button4.BackColor = Color.White;
                label4.Text = "Available";
                listBox1.Items.Remove(client4);
            }
        }

        // ================= ROOM 5 =================
        private void button5_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 5?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration5 = time;
                    client5 = textBox1.Text + " - Room 5";
                    listBox1.Items.Add(client5);

                    button5.Enabled = false;
                    button5.BackColor = Color.Red;
                    label5.Text = "Time left: " + duration5;
                    timer5.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            duration5--;
            label5.Text = "Time left: " + duration5;

            if (duration5 <= 0)
            {
                timer5.Stop();
                button5.Enabled = true;
                button5.BackColor = Color.White;
                label5.Text = "Available";
                listBox1.Items.Remove(client5);
            }
        }

        // ================= ROOM 6 =================
        private void button6_Click(object sender, EventArgs e)
        {
            int time;
            if (int.TryParse(maskedTextBox1.Text, out time) && time > 0 && textBox1.Text != "")
            {
                DialogResult result = MessageBox.Show("Do you want to reserve Room 6?", "Reservation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    duration6 = time;
                    client6 = textBox1.Text + " - Room 6";
                    listBox1.Items.Add(client6);

                    button6.Enabled = false;
                    button6.BackColor = Color.Red;
                    label6.Text = "Time left: " + duration6;
                    timer6.Start();

                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a name and a valid time.");
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            duration6--;
            label6.Text = "Time left: " + duration6;

            if (duration6 <= 0)
            {
                timer6.Stop();
                button6.Enabled = true;
                button6.BackColor = Color.White;
                label6.Text = "Available";
                listBox1.Items.Remove(client6);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}