using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/***************************************************************
* Name        : Array Arguments Algorithm
* Author      : Kabrina Brady
* Created     : 10/8/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : When Go is clicked, random array is generated. Find Max button finds largest number. Find Min button finds smallest number.
*               Input:  Button clicks
*               Output: Numbers in array, MessageBoxes
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace Array_Argument
{
    public partial class ArrayArgumentAlgorithmForm : Form
    {
        //creates global array and random object
        int[] randomArray = new int[15]; //creates new array with 15 values
        Random randInt = new Random(); //creates new random object

        public ArrayArgumentAlgorithmForm()
        {
            InitializeComponent();
        }

        //FindMax method
        private void FindMax(int[]iArray)
        {
            int highest = iArray[0]; //makes the highest value the value of the 0th index in the array

            for (int index = 1; index < iArray.Length; index++) //starts with the value of the 1st index in the array, continues executing as long as the end of the array hasn't been reached, and adds one to index each execution
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index]; //set the new highest value if current value is greater than current max
                }
            }

            MessageBox.Show("The highest value is " + highest); //display message
        }

        //FindMin method
        private void FindMin(int[] iArray)
        {
            int lowest = iArray[0]; //makes the lowest value the value of the 0th index in the array

            for (int index = 1; index < iArray.Length; index++) //starts with the value of the 1st index in the array, continues executing as long as the end of the array hasn't been reached, and adds one to index each execution
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index]; //set the new lowest value if current value is greater than current min
                }
            }

            MessageBox.Show("The lowest value is " + lowest); //display message
        }

        // Click event handler for the goButton control.
        private void goButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < randomArray.Length; index++) //as long as index is less than 15, increment index
            {
                randomArray[index] = randInt.Next(200); //keep generating random numbers and putting them into randomArray
                outputListBox.Items.Add(randomArray[index]); //display contents of the array in listbox
            }
        }

        // Click event handler for the exitButton control.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        //Find Max button click
        private void FindMaxBtn_Click(object sender, EventArgs e)
        {
            //call FindMax method
            FindMax(randomArray);
        }

        //Find Min button click
        private void FindMinBtn_Click(object sender, EventArgs e)
        {
            //call FindMin method
            FindMin(randomArray);
        }
    }
}
