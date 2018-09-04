using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _10_2.Classes;

namespace _10_2
{

    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        //The ShowAnimalInfo method accepts an Animal Object
        //as an argument. It displays the object's species and calls its 'MakeSound' Method
        private void ShowAnimalInfo(Animal animal)
        {
            lbOutPut.Items.Add("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate new 'Animal' Object, give it a name
                Animal newAnimal = new Animal("Regular animal");
                //Pass 'Animal newAnimal' to the method 'ShowAnimalInfo' 
                ShowAnimalInfo(newAnimal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate new 'Dog' Object, give the dog a name
                Dog myDog = new Dog("Shadow");
                //Pass 'Dog myDog' object to the method 'ShowAnimalInfo'
                ShowAnimalInfo(myDog);
                // Add the name of my dog to the list box
                lbOutPut.Items.Add("my dog's name is " + myDog.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            try
            {
                //Instantiate new 'Cat' Object, give the cat a name
                Cat myCat = new Cat("Boots and Spook");
                //Pass 'Cat myCat' object to the method 'ShowAnimalInfo'
                ShowAnimalInfo(myCat);
                //Add the names of the cats to the listbox
                lbOutPut.Items.Add("The cat's names are " + myCat.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Hide this form
                this.Hide();
                //Create the next form object
                AbstractClass nxtForm = new AbstractClass();
                //Display the next form
                nxtForm.ShowDialog();
                //Close this form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbOutPut.Items.Clear();
        }
    }
}
