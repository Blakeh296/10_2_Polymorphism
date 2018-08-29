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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The ShowAnimalInfo method accepts an Animal Object
        //as an argument. It displays the object's species and calls its 'MakeSound' Method
        private void ShowAnimalInfo(Animal animal)
        {
            MessageBox.Show("Species: " + animal.Species);
            animal.MakeSound();
        }

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            //instantiate new 'Animal' Object, give it a name
            Animal newAnimal = new Animal("Regular animal");
            //Pass 'Animal newAnimal' to the method 'ShowAnimalInfo' 
            ShowAnimalInfo(newAnimal);
        }

        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            //instantiate new 'Dog' Object, give the dog a name
            Dog myDog = new Dog("Shadow");
            // Display the name of the dog to the user
            MessageBox.Show("The dog's name is " + myDog.Name);
            //Pass 'Dog myDog' object to the method 'ShowAnimalInfo'
            ShowAnimalInfo(myDog);
        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            //Instantiate new 'Cat' Object, give the cat a name
            Cat myCat = new Cat("Boots and Spook");
            //Display the name of the cat 
            MessageBox.Show("The cat's name is " + myCat.Name);
            //Pass 'Cat myCat' object to the method 'ShowAnimalInfo'
            ShowAnimalInfo(myCat);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create the new form
            _10_3 newForm = new _10_3();
            // And display for the user
            newForm.Show();
        }
    }
}
