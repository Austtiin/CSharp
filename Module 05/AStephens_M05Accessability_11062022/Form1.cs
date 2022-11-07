//Austin Stephens
//11062022
//Example of app reguarding  classes of recipts and section 5 of our weekly homework

namespace AStephens_M05Accessability_11062022
{
    public partial class M05Acess : Form
    {
        public M05Acess()
        {
            InitializeComponent();
        }

        private void M05Acess_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Visible = true;
            splitContainer1.Panel2.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

            comboBox1.Items.Add(new KeyValuePair<string, string>("Accountability", "0"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Eye Conditions", "1"));
            comboBox1.Items.Add(new KeyValuePair<string, string>("Sensitivity", "2"));
            //add more here

            comboBox1.DisplayMember = "key";
            comboBox1.ValueMember = "value";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read val
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            //set key and values to new input(s)
            string key = kvp.Key.ToString();
            string value = kvp.Value.ToString();

            /*
             *
             * Refs for case information
             *Cleave, P. (2021, June 17). Examining the Importance of High Contrast Accessibility in Accommodating Low Vision Users - SmartSurvey. SmartSurvey. https://www.smartsurvey.co.uk/blog/examining-the-importance-of-high-contrast-accessibility-in-accommodating-low-vision-users
            *‌WebAIM: Assistive Technology Experiment: High Contrast. (2012). Webaim.org. https://webaim.org/blog/high-contrast/
*Guest Blogger. (2022, May 19). Why is ADA compliance important? Mead & Hunt. https://meadhunt.com/why-is-ada-compliance-important/#:~:text=Having%20facilities%20that%20are%20not,decrease%20safety%20for%20all%20users.

‌‌
             *
             */

            //Switch to edit test could probably be put into better function
            switch (Convert.ToInt32(kvp.Value))
            {
                case 0:
                    ChangeMe.Text =
                        "The Centers for Disease Control and Prevention (CDC) \nstatistics show that 61 million adults in the United States \nlive with a disability. \n\n While millions of Americans currently live with a disability, \nthere are still plenty of facilities that are not compliant \nwith the standards of the ADA. This results in unnecessary barriers\nfor this vulnerable group—along with potential costly \n lawsuits for owners of these facilities.";
                    break;

                case 1:
                    ChangeMe.Text =
                        "Blurring\n\rLight sensitivity\nReduced field of vision (such as tunnel vision)\nReduced depth perception\nInvoluntary eye movement (such as nystagmus)";
                    break;

                case 2:
                    ChangeMe.Text = "High contrast settings benefit users with low \nvision or other visual disabilities. \n\nThe High Contrast Themes present in Windows change or invert \nweb page background and text colors";
                    break;

                default:
                    ChangeMe.Text = key + "" + value;
                    break;
            }
        }
    }
}