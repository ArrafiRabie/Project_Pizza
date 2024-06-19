using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza_Sr
{
    public partial class Pizza_Order : Form
    {
        static byte Cou = 0;

        public Pizza_Order()
        {
            InitializeComponent();

            Default_RB_Size_Pizza();
            LB_Tayp_Size.Text = "No Size";
     
            thecomponents();
        }

        void Type_Size(string Tayp)
        {
            LB_Tayp_Size.Text = Tayp;
        }

        float Update_Price_Size()
        {
            if (RB_Small.Checked)
            {
                Type_Size(RB_Small.Text);
                return Convert.ToSingle(RB_Small.Tag);
            }

            else if (RB_Medium.Checked)
            {
                Type_Size(RB_Medium.Text);
                return Convert.ToSingle(RB_Medium.Tag);
            }

            else if(RB_Large.Checked)
            {
                Type_Size(RB_Large.Text);
                return Convert.ToSingle(RB_Large.Tag);
            }
            return 0;
        }

        void thecomponents()
        {
            string Chenge = "";

            if (CB_Extra_Cheees.Checked)
                Chenge = CB_Extra_Cheees.Text;
            if (CB_Mushrooms.Checked)
                Chenge += ", " + CB_Mushrooms.Text;
            if (CB_Tomatoes.Checked)
                Chenge += ", " + CB_Tomatoes.Text;
            if (CB_Onion.Checked)
                Chenge += ", " + CB_Onion.Text;
            if (CB_Olives.Checked)
                Chenge += ", " + CB_Olives.Text;
            if (CB_Black_Peppers.Checked)
                Chenge += ", " + CB_Black_Peppers.Text;

            if (Chenge.StartsWith( ","))
            {
                Chenge = Chenge.Substring(1,Chenge.Length - 1);
            }

            LB_Toppings_Order.Text = Chenge;
        }

        short Update_Price_Extra_Cheees() {

            short TotaleToppings = 0;

            if (CB_Extra_Cheees.Checked)
                TotaleToppings += Convert.ToSByte(CB_Extra_Cheees.Tag);
            if (CB_Mushrooms.Checked)
                TotaleToppings += Convert.ToSByte(CB_Mushrooms.Tag);
            if (CB_Tomatoes.Checked)
                TotaleToppings += Convert.ToSByte(CB_Tomatoes.Tag);
            if (CB_Onion.Checked)
                TotaleToppings += Convert.ToSByte(CB_Onion.Tag);
            if (CB_Olives.Checked)
                TotaleToppings += Convert.ToSByte(CB_Olives.Tag);
            if (CB_Black_Peppers.Checked)
                TotaleToppings += Convert.ToSByte(CB_Black_Peppers.Tag);

            return TotaleToppings;
        }

        short Update_Price_Crust()
        {
            short Price_Crust = 0;
            if (RB_Think_Crust.Checked)
                Price_Crust += Convert.ToSByte(RB_Think_Crust.Tag);
            else
                Price_Crust += Convert.ToSByte(RB_Thin_Crust.Tag);

            return Price_Crust;
        }

        short Update_Where_To_Eat()
        {
            short Price_Eat = 0;

            if (RB_Eat_In.Checked)
                Price_Eat += Convert.ToSByte(RB_Eat_In.Tag);
            else
                Price_Eat += Convert.ToSByte(RB_Take_out.Tag);

            return Price_Eat;
        }

        short Update_Drinks()
        {
            short Price_Drinks = 0;
            if (CB_Lemon.Checked)
                Price_Drinks += Convert.ToSByte(CB_Lemon.Tag);
            if (CB_Water.Checked)
                Price_Drinks += Convert.ToSByte(CB_Water.Tag);
            if (CB_Cola.Checked)
                Price_Drinks += Convert.ToSByte(CB_Cola.Tag);
            if (CB_Sprite.Checked)
                Price_Drinks += Convert.ToSByte(CB_Sprite.Tag);

            return Price_Drinks;
        }

        float Calcult_Price()
        {
            return Update_Price_Size() + Update_Price_Extra_Cheees() +
                Update_Price_Crust() + Update_Where_To_Eat() + Update_Drinks();
        }

        void Update_totale_Price()
        {
            LB_Price.Text = "$" + Calcult_Price().ToString();
        }

        private void RB_Small_CheckedChanged(object sender, EventArgs e)
        {
            RB_Small.Tag = 20;
            Update_totale_Price();
        }

        private void RB_Medium_CheckedChanged(object sender, EventArgs e)
        {
            RB_Medium.Tag = 30;
            Update_totale_Price();
        }

        private void RB_Large_CheckedChanged(object sender, EventArgs e)
        {
            RB_Large.Tag = 40;
            Update_totale_Price();
        }

        private void CB_Extra_Cheees_CheckedChanged(object sender, EventArgs e)
        {
            CB_Extra_Cheees.Tag = 7;
            Update_totale_Price();
            thecomponents();
        }

        private void CB_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            CB_Mushrooms.Tag = 5;
            Update_totale_Price();
            thecomponents();
        }

        private void CB_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            CB_Tomatoes.Tag = 5;
            Update_totale_Price();
            thecomponents();
        }

        private void CB_Onion_CheckedChanged(object sender, EventArgs e)
        {
            CB_Onion.Tag = 5;
            Update_totale_Price();
            thecomponents();
        }

        private void CB_Olives_CheckedChanged(object sender, EventArgs e)
        {
            CB_Olives.Tag = 5;
            Update_totale_Price();
            thecomponents();
        }

        private void CB_Black_Peppers_CheckedChanged(object sender, EventArgs e)
        {
            CB_Black_Peppers.Tag = 5;
            Update_totale_Price();
            thecomponents();
        }

        private void RB_Thin_Crust_CheckedChanged(object sender, EventArgs e)
        {
            RB_Thin_Crust.Tag = 0;
            Update_totale_Price();

            Update_Lb_Crust_Type();
        }

        private void RB_Think_Crust_CheckedChanged(object sender, EventArgs e)
        {
            RB_Think_Crust.Tag = 5;
            Update_totale_Price();

            Update_Lb_Crust_Type();
        }

        private void RB_Eat_In_CheckedChanged(object sender, EventArgs e)
        {
            RB_Eat_In.Tag = 5;
            Update_totale_Price();
            Update_Eat();
        }

        private void RB_Take_out_CheckedChanged(object sender, EventArgs e)
        {
            RB_Take_out.Tag = 0;
            Update_totale_Price();
            Update_Eat();
        }

        void Desabled_GB_Eat()
        {
            Where_To_Eat.Enabled = false;
        }

        void Desabled_GB_Crust_type()
        {
            GB_Crust_type.Enabled = false;
        }

        void Desabled_GB_Pizza_Size()
        {
            GB_Pizza_Size.Enabled = false;
        }

        void Desabled_GB_Toppings()
        {
            GB_Toppings.Enabled = false;
        }

        void Desabled_GB_Drinks()
        {
            GB_Drinks.Enabled = false;
        }

        private void BT_Order_Pizza_Click(object sender, EventArgs e)
        {
            Desabled_GB_Eat();
            Desabled_GB_Crust_type();
            Desabled_GB_Pizza_Size();
            Desabled_GB_Toppings();
            Desabled_GB_Drinks();
            BT_Order_Pizza.Enabled = false;
        }

        void Enabled_GB_Eat()
        {
            Where_To_Eat.Enabled = true;
        }

        void Enabled_GB_Crust_type()
        {
            GB_Crust_type.Enabled = true;
        }

        void Enabled_GB_Pizza_Size()
        {
            GB_Pizza_Size.Enabled = true;
        }

        void Enabled_GB_Toppings()
        {
            GB_Toppings.Enabled = true;
        }

        void Enabled_GB_Drinks()
        {
            GB_Drinks.Enabled = true;
        }

        void Default_CB_Toppings()
        {
            CB_Extra_Cheees.Checked = false;
            CB_Black_Peppers.Checked = false;
            CB_Mushrooms.Checked = false;
            CB_Olives.Checked = false;
            CB_Onion.Checked = false;
            CB_Tomatoes.Checked = false;
        }

        void Default_RB_Size_Pizza()
        {
            RB_Small.Checked = false;
            RB_Medium.Checked = false;
            RB_Large.Checked = false;
        }

        void Default_RB_Eat()
        {
            RB_Eat_In.Checked = false;
            RB_Take_out.Checked = false;
        }

        void Default_RB_Crust()
        {
            RB_Think_Crust.Checked = false;
            RB_Thin_Crust.Checked = false;
        }

        void Default_CB_Drinks()
        {
            CB_Lemon.Checked = false;
            CB_Cola.Checked = false;
            CB_Sprite.Checked = false;
            CB_Water.Checked = false;
        }

        //========================
        void Default_LB_Type_Size()
        {
            LB_Tayp_Size.Text = default;
        }
        //========================

        private void BT_Reset_From_Click(object sender, EventArgs e)
        {
            Enabled_GB_Eat();
            Enabled_GB_Crust_type();
            Enabled_GB_Pizza_Size();
            Enabled_GB_Toppings();
            Enabled_GB_Drinks();
            Default_CB_Toppings();
            Default_RB_Size_Pizza();
            Default_RB_Eat();
            Default_RB_Crust();
            Default_CB_Drinks();
            Default_LB_Type_Size();
            BT_Order_Pizza.Enabled = true;

            LB_Price.Text = "$ 0";
        }

        private void CB_Water_CheckedChanged(object sender, EventArgs e)
        {
            CB_Water.Tag = 5;
            Update_totale_Price();
            Update_Order_Drinks();
        }

        private void CB_Lemon_CheckedChanged(object sender, EventArgs e)
        {
            CB_Lemon.Tag = 8;
            Update_totale_Price();
            Update_Order_Drinks();
        }

        private void CB_Sprite_CheckedChanged(object sender, EventArgs e)
        {
            CB_Sprite.Tag = 7;
            Update_totale_Price();
            Update_Order_Drinks();
        }

        private void CB_Cola_CheckedChanged(object sender, EventArgs e)
        {
            CB_Cola.Tag = 6;
            Update_totale_Price();
            Update_Order_Drinks();
        }

        void Update_Lb_Crust_Type()
        {
            string Cheng = "";
            if (RB_Thin_Crust.Checked)
            {
                Cheng = RB_Thin_Crust.Text;
            }

            if (RB_Think_Crust.Checked)
            {
                Cheng = RB_Think_Crust.Text;
            }

            LB_Crust_Type.Text = Cheng;
        }

        void Update_Eat()
        {
            string Eat = "";
            if(RB_Eat_In.Checked)
            {
                Eat = RB_Eat_In.Text;
            }

            if(RB_Take_out.Checked)
            {
                Eat = RB_Take_out.Text;
            }

            LB_Eat.Text = Eat;
        }

        void Update_Order_Drinks()
        {
            string Drinks = "";

            if (CB_Lemon.Checked)
            {
                Drinks = CB_Lemon.Text;
            }

            if (CB_Water.Checked)
            {
                Drinks += "," + CB_Water.Text;
            }

            if(CB_Sprite.Checked)
            {
                 Drinks += "," + CB_Sprite.Text;
            }

            if(CB_Cola.Checked)
            {
                Drinks += "," + CB_Cola.Text;
            }

            if (Drinks.StartsWith(","))
            {
                Drinks = Drinks.Substring(1,Drinks.Length-1);
            }

            LB_DrinkS.Text = Drinks;
        }

        private void Pizza_Order_Load(object sender, EventArgs e)
        {

        }

        ~Pizza_Order()
        {
            Cou = 0;
        }
    }
}

//1347, 788
