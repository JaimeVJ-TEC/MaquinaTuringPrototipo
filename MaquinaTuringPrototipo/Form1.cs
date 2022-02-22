using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MaquinaTuringPrototipo
{
    public partial class Form1 : Form
    {
        Maquina MaquinaT = new Maquina();

        public Form1()
        {
            InitializeComponent();

            //Inicializacion de forms
            cboOperacion.SelectedIndex = 0;

            //Parametros de Listview que muestra la cadena
            listView1.View = View.Tile;
            listView1.Alignment = ListViewAlignment.Left;
            listView1.OwnerDraw = true;
            listView1.DrawItem += listView1_DrawItem;
            listView1.TileSize = new Size(30,
            listView1.ClientSize.Height - (SystemInformation.HorizontalScrollBarHeight+1));

            //Parametros de ListView que muestra las operacione (Maquina compuesta)
            listView2.View = View.Tile;
            listView2.Alignment = ListViewAlignment.Left;
            listView2.OwnerDraw = true;
            listView2.DrawItem += listView2_DrawItem;
            listView2.TileSize = new Size(25,
            listView2.ClientSize.Height - (SystemInformation.HorizontalScrollBarHeight));
        }

        //Evento para dibujar un elemento del Listview que muestra la cadena
        void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color textColor = Color.Black;

            if (e.Item.Selected == true)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                e.DrawFocusRectangle();
                textColor = SystemColors.HighlightText;
            }
            else if(e.Item.Checked)
            {
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                e.DrawFocusRectangle();
                textColor = SystemColors.HighlightText;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            e.Graphics.DrawRectangle(Pens.DarkGray, e.Bounds);

            TextRenderer.DrawText(e.Graphics, e.Item.Text, listView1.Font, e.Bounds,
                                  textColor, Color.Empty,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        //Evento para dibujar un elemento del Listview que muestra las operaciones
        void listView2_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color textColor = Color.Black;

            if (e.Item.Selected == true)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                textColor = SystemColors.HighlightText;
            }
            else if (e.Item.Checked)
            {
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                textColor = SystemColors.HighlightText;
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }
            e.Graphics.DrawRectangle(Pens.White, e.Bounds);

            TextRenderer.DrawText(e.Graphics, e.Item.Text, listView1.Font, e.Bounds,
                                  textColor, Color.Empty,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void btnAgregarSimbolo_Click(object sender, EventArgs e)
        {
            if (txtSimbolo.Text.Length == 1)
            {
                if (txtSimbolo.Text == "Δ" || txtSimbolo.Text == "#" || txtSimbolo.Text == " ")
                {
                    MessageBox.Show("Simbolo reservado");
                }
                else
                {
                    MaquinaT.Cinta.Alfabeto.Add(char.Parse(txtSimbolo.Text));
                }
            }
            else
            {
                MessageBox.Show("Agregue solo un simbolo a la vez");
            }

            ActualizarAlfabeto();
        }

        private void btnEliminarAlfabeto_Click(object sender, EventArgs e)
        {
            if (MaquinaT.Cinta.Alfabeto.Count != 0)
            {
                MaquinaT.Cinta.Alfabeto.RemoveAt(MaquinaT.Cinta.Alfabeto.Count - 1);
                ActualizarAlfabeto();
            }
        }

        public void ActualizarAlfabeto()
        {
            lblAlfabeto.Text = "";
            foreach(char a in MaquinaT.Cinta.Alfabeto)
            {
                lblAlfabeto.Text = lblAlfabeto.Text + " " + a;
            }
        }

        private void btnAgregarCadena_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCadena.Text.Length == 1)
                {
                    MaquinaT.Cinta.AgregarCadena(char.Parse(txtCadena.Text));
                }
                else
                {
                    MessageBox.Show("Simbolo no valido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ActualizarCadena();
        }

        private void btnVacioCadena_Click(object sender, EventArgs e)
        {
            MaquinaT.Cinta.AgregarCadena('Δ');
            ActualizarCadena();
        }

        private void btnEliminarCadena_Click(object sender, EventArgs e)
        {
            if (MaquinaT.Cinta._Cadena.Count > 0)
            {
                MaquinaT.Cinta._Cadena.RemoveAt(MaquinaT.Cinta._Cadena.Count - 1);
            }
            ActualizarCadena();
        }

        public void ActualizarCadena()
        {
            listView1.Items.Clear();
            foreach (char a in MaquinaT.Cinta._Cadena)
            {
                listView1.Items.Add(a.ToString());
            }
        }

        private void btnPosicionInicial_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                int Posicion = 0;

                foreach (ListViewItem L in listView1.Items)
                {
                    if (L.Checked)
                        L.Checked = false;
                }

                foreach (ListViewItem L in listView1.Items)
                {
                    if (L.Selected)
                    {
                        L.Checked = true;
                        break;
                    }
                    Posicion++;
                }
                MaquinaT.Cinta.PosiciconInicial = Posicion;
                MaquinaT.Cinta.PosicionActual = Posicion;
                listView1.SelectedItems.Clear();
            }
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Operacion op = new Operacion();
            switch (cboOperacion.SelectedIndex)
            {
                case 0:
                    op.Tipo = "Movimiento";
                    op.Derecha = true;
                    MaquinaT.Operaciones.Add(op);
                    break;

                case 1:
                    op.Tipo = "Movimiento";
                    op.Derecha = false;
                    MaquinaT.Operaciones.Add(op);
                    break;

                case 2:
                    op.Tipo = "Busqueda";
                    op.Derecha = true;

                    if (chkNegacionOp.Checked)
                        op.Negacion = true;
                    else
                        op.Negacion = false;

                    if (txtSimboloBusqueda.Text != "" || txtSimboloBusqueda.Text.Length == 1)
                    {
                        char SubSimbolo = char.Parse(txtSimboloBusqueda.Text);
                        if (SubSimbolo == '#' || SubSimbolo == 'Δ' || MaquinaT.Cinta.Alfabeto.Contains(SubSimbolo))
                        {
                            op.Simbolo = SubSimbolo;
                            MaquinaT.Operaciones.Add(op);
                        }
                        else
                            MessageBox.Show("Simbolo no valido");
                    }
                    else
                        MessageBox.Show("Simbolo no valido");
                    break;

                case 3:
                    op.Tipo = "Busqueda";
                    op.Derecha = false;

                    if (chkNegacionOp.Checked)
                        op.Negacion = true;
                    else
                        op.Negacion = false;

                    if (txtSimboloBusqueda.Text != "" || txtSimboloBusqueda.Text.Length == 1)
                    {
                        char SubSimbolo = char.Parse(txtSimboloBusqueda.Text);
                        if (SubSimbolo == '#' || SubSimbolo == 'Δ' || MaquinaT.Cinta.Alfabeto.Contains(SubSimbolo))
                        {
                            op.Simbolo = SubSimbolo;
                            MaquinaT.Operaciones.Add(op);
                        }
                        else
                            MessageBox.Show("Simbolo no valido");
                    }
                    else
                        MessageBox.Show("Simbolo no valido");
            break;

                case 4:
                    op.Tipo = "Sobreescribir";
                    if (txtSimboloReescribir.Text != "" || txtSimboloReescribir.Text.Length == 1)
                    {
                        char SimboloEscribir = char.Parse(txtSimboloReescribir.Text);
                        if (SimboloEscribir == 'σ' || SimboloEscribir == '#' || SimboloEscribir == 'Δ' || MaquinaT.Cinta.Alfabeto.Contains(SimboloEscribir))
                        {
                            op.Simbolo = SimboloEscribir;
                            MaquinaT.Operaciones.Add(op);
                        }
                        else
                            MessageBox.Show("Simbolo no valido");
                    }
                    else
                        MessageBox.Show("Simbolo no valido");
                    break;

                case 5:
                    op.Tipo = "Guardar";
                    MaquinaT.Operaciones.Add(op);
                    break;

                case 6:
                    op.Tipo = "N";
                    MaquinaT.Operaciones.Add(op);
                    break;
            }
            ActualizarOperaciones();
        }

        private void cboOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboOperacion.SelectedIndex)
            {
                case 0:
                    txtSimboloBusqueda.Enabled = false;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = false;
                    btnDelta.Enabled = false;
                    button1.Enabled = false;
                    break;

                case 1:
                    txtSimboloBusqueda.Enabled = false;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = false;
                    btnDelta.Enabled = false;
                    button1.Enabled = false;
                    break;

                case 2:
                    txtSimboloBusqueda.Enabled = true;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = true;
                    btnDelta.Enabled = false;
                    button1.Enabled = true;
                    break;

                case 3:
                    txtSimboloBusqueda.Enabled = true;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = true;
                    btnDelta.Enabled = false;
                    button1.Enabled = true;
                    break;

                case 4:
                    txtSimboloBusqueda.Enabled = false;
                    txtSimboloReescribir.Enabled = true;
                    chkNegacionOp.Enabled = false;
                    btnDelta.Enabled = true;
                    button1.Enabled = false;
                    break;

                case 5:
                    txtSimboloBusqueda.Enabled = false;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = false;
                    btnDelta.Enabled = false;
                    button1.Enabled = false;
                    break;

                case 6:
                    txtSimboloBusqueda.Enabled = false;
                    txtSimboloReescribir.Enabled = false;
                    chkNegacionOp.Enabled = false;
                    btnDelta.Enabled = false;
                    button1.Enabled = false;
                    break;
            }
        }

        public void ActualizarOperaciones()
        {
            listView2.Items.Clear();
            int Num = 1;
            foreach(Operacion op in MaquinaT.Operaciones)
            {
                switch(op.Tipo)
                {
                    case "Movimiento":
                        if (op.Derecha)
                            listView2.Items.Add("D\n"+Num);
                        else
                            listView2.Items.Add("I\n" + Num);
                        break;

                    case "Busqueda":
                        if(op.Derecha && !op.Negacion)
                            listView2.Items.Add("D" + op.Simbolo  +"\n" + Num);
                        else if (!op.Derecha && !op.Negacion)
                            listView2.Items.Add("I" + op.Simbolo + "\n" + Num);
                        else if (op.Derecha && op.Negacion)
                            listView2.Items.Add("D¬" + op.Simbolo + "\n" + Num);
                        else if (!op.Derecha && op.Negacion)
                            listView2.Items.Add("I¬" + op.Simbolo + "\n" + Num);
                        break;

                    case "Sobreescribir":
                        if (op.Derecha)
                            listView2.Items.Add(op.Simbolo.ToString() + "\n" + Num);
                        else
                            listView2.Items.Add(op.Simbolo.ToString() + "\n" + Num);
                        break;

                    case "Guardar":
                        listView2.Items.Add("σ" + "\n" + Num);
                        break;

                    case "N":
                        listView2.Items.Add("N" + "\n" + Num);
                        break;
                }
                Num++;
            }
        }

        public void ActualziarDecisiones()
        {
            listBox1.Items.Clear();
            if (listView2.SelectedItems.Count > 0)
            {
                int Posicion = 0;

                foreach (ListViewItem L in listView2.Items)
                {
                    if (L.Selected)
                        break;
                    Posicion++;
                }

                foreach (Decision d in MaquinaT.Operaciones[Posicion].Decisiones)
                {
                    if(d.Negacion && d.Condicion!='\0')
                        listBox1.Items.Add("¬"+d.Condicion + " → (" + (d.OperacionDestino + 1) + ")");
                    else if (!d.Negacion && d.Condicion != '\0')
                        listBox1.Items.Add(d.Condicion + " → (" + (d.OperacionDestino + 1) + ")");
                    else if (d.Negacion && d.Condicion == '\0')
                        listBox1.Items.Add(" → (" + (d.OperacionDestino + 1) + ")");
                    else
                        listBox1.Items.Add(" → (" + (d.OperacionDestino + 1) + ")");
                }
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualziarDecisiones();
        }

        private void btnDecision_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (txtDecision.Text.Length <= 1)
                {
                    char Simbolo;

                    if (txtDecision.Text == "")
                        Simbolo = '\0';
                    else
                        Simbolo = char.Parse(txtDecision.Text);

                    if (Simbolo == '#' || Simbolo == 'Δ' || MaquinaT.Cinta.Alfabeto.Contains(Simbolo) || Simbolo =='\0')
                    {
                        int Posicion = 0;

                        foreach (ListViewItem L in listView2.Items)
                        {
                            if (L.Selected)
                                break;
                            Posicion++;
                        }

                        Decision decision = new Decision();
                        decision.OperacionOrig = Posicion;
                        decision.OperacionDestino = (int)numDestino.Value - 1;
                        decision.Condicion = Simbolo;
                        decision.Negacion = chkNegacionDec.Checked;

                        MaquinaT.Operaciones[Posicion].Decisiones.Add(decision);
                        ActualziarDecisiones();
                    }
                    else
                        MessageBox.Show("Simbolo no valido");
                }
                else
                    MessageBox.Show("Simbolo no valido");
            }
        }

        private void btnEjecutarPasos_Click(object sender, EventArgs e)
        {
            try
            {
                bool Checked = false;
                foreach (ListViewItem L in listView1.Items)
                {
                    if (L.Checked)
                        Checked = true;
                }

                if (Checked)
                {
                    ActualizarCadena();
                    listView1.SelectedItems.Clear();
                    listView2.SelectedItems.Clear();

                    foreach (ListViewItem L in listView1.Items)
                    {
                        if (L.Checked)
                            L.Checked = false;
                    }

                    foreach (ListViewItem L in listView2.Items)
                    {
                        if (L.Checked)
                            L.Checked = false;
                    }

                    listView1.Items[MaquinaT.Cinta.PosicionActual].Checked = true;

                    if (MaquinaT.OperacionActual == listView2.Items.Count)
                    {
                        foreach (ListViewItem L in listView2.Items)
                        {
                            if (L.Checked)
                                L.Checked = false;
                        }
                    }
                    else
                    {
                        listView2.Items[MaquinaT.OperacionActual].Checked = true;
                    }

                    MaquinaT.EjecutarOperacion();
                }
                else
                {
                    MessageBox.Show("Seleccione la posicion inicial del cabezal");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelta_Click(object sender, EventArgs e)
        {
            txtSimboloReescribir.Text = "Δ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSimboloBusqueda.Text = "Δ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDecision.Text = "Δ";
        }

        private void btnOperacionEliminar_Click(object sender, EventArgs e)
        {
            MaquinaT.Operaciones.RemoveAt(MaquinaT.Operaciones.Count - 1);
            ActualizarOperaciones();
        }

        private void btnDecisionEliminar_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listBox1.SelectedItem != null)
                {
                    int Posicion = 0;
                    foreach (ListViewItem L in listView2.Items)
                    {
                        if (L.Selected)
                            break;
                        Posicion++;
                    }

                    MaquinaT.Operaciones[Posicion].Decisiones.RemoveAt(listBox1.SelectedIndex);
                    ActualziarDecisiones();
                }
            }
        }

        private void btnReiniciarCadena_Click(object sender, EventArgs e)
        {
            MaquinaT.Cinta.PosicionActual = MaquinaT.Cinta.PosiciconInicial;
            ActualizarCadena();
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();

            foreach (ListViewItem L in listView1.Items)
            {
                if (L.Checked)
                    L.Checked = false;
            }

            foreach (ListViewItem L in listView2.Items)
            {
                if (L.Checked)
                    L.Checked = false;
            }

            listView1.Items[MaquinaT.Cinta.PosicionActual].Checked = true;

            if (MaquinaT.OperacionActual == listView2.Items.Count)
            {
                foreach (ListViewItem L in listView2.Items)
                {
                    if (L.Checked)
                        L.Checked = false;
                }
            }
            else
            {
                listView2.Items[MaquinaT.OperacionActual].Checked = true;
            }
        }

        private void btnReiniciarOperaciones_Click(object sender, EventArgs e)
        {
            MaquinaT.OperacionActual = 0;
            ActualizarOperaciones();
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();

            foreach (ListViewItem L in listView1.Items)
            {
                if (L.Checked)
                    L.Checked = false;
            }

            foreach (ListViewItem L in listView2.Items)
            {
                if (L.Checked)
                    L.Checked = false;
            }

            listView1.Items[MaquinaT.Cinta.PosicionActual].Checked = true;

            if (MaquinaT.OperacionActual == listView2.Items.Count)
            {
                foreach (ListViewItem L in listView2.Items)
                {
                    if (L.Checked)
                        L.Checked = false;
                }
            }
            else
            {
                listView2.Items[MaquinaT.OperacionActual].Checked = true;
            }
        }

        private void btnEscribirMemoria_Click(object sender, EventArgs e)
        {
            txtSimboloReescribir.Text = "σ";
        }
    }
}
