using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebServiceExam1
{
    
    public partial class MainForm : System.Web.UI.Page
    {
        //Todo lo que esta comentado ha sido mi intento de hacer que se pueda añadir mas de un contador a la vez, pero he tenido problemas al poner
        //mas de uno y actuar solo sabiendo el id ya que no he sabido recoger cual era ese textbox desde el code behind, así que he cambiado a hacer un contador simple
        //static int actualCount = 0;
        //Al final he conseguido hacer un countdown pero el timer se repite al acabar un segundo
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            //Add.Click += new EventHandler(this.addCountdown);
             start.Click += new EventHandler(this.countNumbers);
            
        }
        void countNumbers(Object sender, EventArgs e)
        {
            int result = 0;
            string input = countdown.Text;
            try
            {
                result = Int32.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            TimeSpan time = TimeSpan.FromSeconds(result);
            string str = time.ToString(@"hh\:mm\:ss");
            Label1.Text = str;
            timer.Enabled = true;


        }
        protected void tick(object sender, EventArgs e)
        {
            TimeSpan result = TimeSpan.FromSeconds(TimeSpan.Parse(Label1.Text).TotalSeconds - 1);
            string fromTimeString = result.ToString(@"hh\:mm\:ss");
            Label1.Text = fromTimeString;
        }

        /*void addCountdown(Object sender, EventArgs e)
        {
            
            actualCount++;
            countdown();
        }
           void countdown()
          {
              for(int i=1; i <= actualCount; i++)
              {
                  var newCount = new TextBox
                  {
                      ID = i.ToString(),
                      Width = 30,

                  };
                  var buttonStart = new Button
                  {
                      ID = i.ToString(),
                      Text = "Start"

                  };
                  contentArea.Controls.Add(newCount);
                  contentArea.Controls.Add(buttonStart);
              }
          }

         *void startCount(Object sender, EventArgs e)
          {
              string id;
              Button button = sender as Button;
              if (button != null)
              {
                  id = button.ID;
              }

          }*/

    }
}