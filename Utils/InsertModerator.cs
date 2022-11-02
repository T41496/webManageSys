using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace webTRON_Management_Software.Utils
{ 
   public class InsertModerator
    {
        //array of different sections og the patient treatment panel to store their data temporarily
         History[] historyObjectArray = new History[5] ;

         Medicine[] medicineObjectArray = new Medicine[5];

        public InsertModerator()
        {
            //initialize the arrays with objects
            
            for (int i = 0; i < 5; i++)
            {
                historyObjectArray[i] = new History();
                medicineObjectArray[1] = new Medicine();
            }
            

        }

        public int objectCount { get; set; }
        public  bool add(string componentName, string value)
        { 
            //split received component name to find which object should be worked with
            string[] elementsLists = componentName.Split('_');
            string panel = elementsLists[0];
            string component = elementsLists[1];
            int objectNumber = Convert.ToInt32(elementsLists[2]);
           // MessageBox.Show("the value of component name is: "+componentName);
            if(panel=="history")
            {
                //MessageBox.Show("inside history");

                if (component == "textbox")
                {
                    //MessageBox.Show("inside textbox value is "+value);
                    historyObjectArray[objectNumber-1].title = value;
                    //MessageBox.Show("the inserted value is :" + historyObjectArray[objectNumber-1].title);
                }
                if (component == "textArea")
                {
                    //MessageBox.Show("inside textarea");
                    historyObjectArray[objectNumber-1].prescription = value;
                }
            }
            /*
            if (panel == "medicine")
            {
                if (component == "textBox")
                {
                    medicineObjectArray[objectNumber].title = value;
                }
                if (component == "textArea")
                {
                    medicineObjectArray[objectNumber].prescription = value;
                }
            }
            */
            return false;
        }

        public bool hasValue(string componentName, int noOfFeilds)
        {

            //split received component name to find which object should be worked with
            //string[] elementsLists = componentName.Split('_');
            string[] elementLists=InsertModerator.splitter(componentName);
            string panel = elementLists[0];
            string component = elementLists[1];
            int objectNumber = Convert.ToInt32(elementLists[2]);
            //MessageBox.Show(panel + ", " + component + ", " + objectNumber);
            //MessageBox.Show("The read value from the object is: " + historyObjectArray);
          
            //MessageBox.Show("The read value from the object is: " + historyObjectArray[noOfFeilds - 1].title);
            if (panel == "history" && component == "textbox")
            {
                // MessageBox.Show("Inside history,textbox;The read value from the object is: "+ historyObjectArray[noOfFeilds - 1].title);
                return !String.IsNullOrEmpty(historyObjectArray[noOfFeilds - 1].title);
       
            }
            else { return false; }
        }
        public static string[] splitter(string componentName)
        {
            string[] elementsArray = componentName.Split('_');
            return elementsArray;
        }
    }
}
