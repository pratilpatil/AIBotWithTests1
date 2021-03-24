using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AIMLbot;
using System.IO;

public partial class MasterPage : System.Web.UI.MasterPage
{
    private object textBox1;
    private object textBox2;

    protected void Page_Load(object sender, EventArgs e)
    {
        //public Form1()
        {
            InitializeComponent();
        }

    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    //public partial class Form1 : Form

    protected void Button1_Click(object sender, EventArgs e)
    {
        Bot AI = new Bot();

        AI.loadSettings(); //It will load Default Setting from its Config Folder with this 
        AI.loadAIMLFromFiles();//with this code it will load AIML Files from its ALML Folder
        AI.isAcceptingUserInput = false; // with this code it will Disable User Input For Now
        User myuser = new User("Username Here", AI); //with this code we will add the user through AI/Bot
        AI.isAcceptingUserInput = true; // Now the user input is enabled again code
        Request r = new Request(textBox1.Text, myuser, AI); //with this code it will request the response from AIML Folders
        Result res = AI.Chat(r); //with this code it will  get result
        textBox2.Text = "Tutorial Bot: " + res.Output; //with this code it will write
    }
}
