using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Paint
{
    public enum Figuras
    {

        Lapiz,
        Brocha,
        Cubeta,
        Borrador,
        Texto,
        Linea,
        Circulo,
        Cuadrado,
        Triangulo,
        Hexagono

    }
    public partial class frmPaint : Form
    {
        Figuras figuraActiva;
        ToolStripButton seleccionado;
        bool estaPintando;
        bool guardada = false;
        string nombreImagen = "";

        private Point[] puntos;
        private Point primerPunto, segundoPunto;
        Bitmap canvas;
        Graphics objetoDibujador;
        Font drawFont;
        string textoBase;
        int numeroLados;
        int timesClicked;
        Point[] puntosPoligono;


        public void AgregarPuntos(Point nuevoPunto)
        {
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = nuevoPunto;
        }

        public frmPaint()
        {
            InitializeComponent();
            puntos = new Point[0];
            canvas = new Bitmap(imgActual.Width, imgActual.Height);
            figuraActiva = Figuras.Lapiz;
            estaPintando = false;
            seleccionado = btnLapiz;
            timesClicked = 0;
            numeroLados = (int)numPoligono.Value;
            puntosPoligono = new Point[numeroLados];
        }

        private void frmPaint_Load(object sender, EventArgs e)
        {
            
        }

        private void imgActual_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = string.Format("X:{0} Y:{1}", e.X.ToString(), e.Y.ToString());
            if (estaPintando)
            {
                switch (figuraActiva)
                {
                    case Figuras.Lapiz:
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            
                            Pen miLapiz = new Pen(Color.Black, 1);
                            objetoDibujador.DrawLines(miLapiz, puntos);
                        }
                        break;
                    case Figuras.Brocha:
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);
                            objetoDibujador.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                            Pen miLapiz = new Pen(btnColor.BackColor, Convert.ToSingle(numTamano.Value));
                            objetoDibujador.DrawLines(miLapiz, puntos);
                        }
                        break;
                    case Figuras.Cubeta:
                        break;
                    case Figuras.Borrador:
                        AgregarPuntos(new Point(e.X, e.Y));
                        if (puntos.Length > 1)
                        {
                            imgActual.Image = canvas;
                            objetoDibujador = Graphics.FromImage(canvas);

                            Pen miLapiz = new Pen(Color.White, Convert.ToSingle(numTamano.Value));
                            objetoDibujador.DrawLines(miLapiz, puntos);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void imgActual_MouseDown(object sender, MouseEventArgs e)
        {
            estaPintando = true;
            lblStatus.Text = "Esta Dibujando";
            primerPunto = new Point(e.X, e.Y);

            Pen miLapiz = new Pen(btnColor.BackColor, (float)numTamano.Value);
            SolidBrush brush = new SolidBrush(btnColor.BackColor);

            if (figuraActiva == Figuras.Hexagono)
            {
                if (timesClicked < numeroLados)
                {
                    puntosPoligono[timesClicked] = new Point(e.X,e.Y);
                    timesClicked++;
                }
                if (timesClicked == numeroLados)
                {
                    objetoDibujador.DrawPolygon(miLapiz, puntosPoligono);
                    if (cbxFondo.Checked)
                    {
                        objetoDibujador.FillPolygon(brush, puntosPoligono);
                    }
                    puntosPoligono = new Point[numeroLados];
                    timesClicked = 0;
                }
            }

        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            string objname = ((ToolStripButton)sender).Name;
            


            switch (objname)
            {
                case "btnLapiz":
                    figuraActiva = Figuras.Lapiz;
                    seleccionado.Checked = false;
                    seleccionado = btnLapiz;
                    seleccionado.Checked = true;
                    break;
                case "btnBrocha":
                    figuraActiva = Figuras.Brocha;
                    seleccionado.Checked = false;
                    seleccionado = btnBrocha;
                    seleccionado.Checked = true;
                    break;
                case "btnCubeta":
                    figuraActiva = Figuras.Cubeta;
                    seleccionado.Checked = false;
                    seleccionado = btnCubeta;
                    seleccionado.Checked = true;
                    break;
                case "btnBorrar":
                    figuraActiva = Figuras.Borrador;
                    seleccionado.Checked = false;
                    seleccionado = btnBorrar;
                    seleccionado.Checked = true;
                    break;
                case "btnTexto":
                    figuraActiva = Figuras.Texto;
                    seleccionado.Checked = false;
                    seleccionado = btnTexto;
                    seleccionado.Checked = true;
                    frmFontDialog frmFontDialog = new frmFontDialog();
                    frmFontDialog.ShowDialog(this);

                    textoBase = frmFontDialog.Mytext;
                    drawFont = frmFontDialog.Myfont;
                    break;
                case "btnLinea":
                    figuraActiva = Figuras.Linea;
                    seleccionado.Checked = false;
                    seleccionado = btnLinea;
                    seleccionado.Checked = true;
                    break;
                case "btnCirculo":
                    figuraActiva = Figuras.Circulo;
                    seleccionado.Checked = false;
                    seleccionado = btnCirculo;
                    seleccionado.Checked = true;
                    break;
                case "btnCuadrado":
                    figuraActiva = Figuras.Cuadrado;
                    seleccionado.Checked = false;
                    seleccionado = btnCuadrado;
                    seleccionado.Checked = true;
                    break;
                case "btnTriangulo":
                    figuraActiva = Figuras.Triangulo;
                    seleccionado.Checked = false;
                    seleccionado = btnTriangulo;
                    seleccionado.Checked = true;
                    break;
                case "btnHexagono":
                    figuraActiva = Figuras.Hexagono;
                    seleccionado.Checked = false;
                    seleccionado = btnHexagono;
                    seleccionado.Checked = true;
                    break;
                default:
                    break;
            }

            lblFiguraActiva.Text = figuraActiva.ToString();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            canvas = new Bitmap(imgActual.Width, imgActual.Height);
            imgActual.Image = null;
            guardada = false;
        }

        private void btnPaleta_Click(object sender, EventArgs e)
        {
            if (cdgPaletaColores.ShowDialog()==DialogResult.OK)
            {
                btnColor.BackColor = cdgPaletaColores.Color;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {         
            ImageFormat imageFormat = ImageFormat.Png;

            
            if (guardada)
            {
                Bitmap saveImage = new Bitmap(imgActual.Width, imgActual.Height);
                var rec = new Rectangle(0, 0, imgActual.Width, imgActual.Height);
                imgActual.DrawToBitmap(saveImage, rec);

                imgActual.Image.Save(nombreImagen);
            }
            else if (!guardada)
            {
                sfdSave.Filter = "PNG| .png |JPEG| .jpeg";
                sfdSave.Title = "Guardar Imagen Como ...";
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {

                    Bitmap saveImage = new Bitmap(imgActual.Width, imgActual.Height);
                    var rec = new Rectangle(0, 0, imgActual.Width, imgActual.Height);

                    imgActual.DrawToBitmap(saveImage, rec);
    
                    imgActual.Image.Save(sfdSave.FileName);
                    nombreImagen = sfdSave.FileName;
                    guardada = true;
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == DialogResult.OK) 
            {
                var imagen = ofdAbrir.FileName;
                imgActual.Image = Image.FromFile(imagen);
                var bmp = (Bitmap)imgActual.Image;
                canvas = bmp;
                guardada = false;
            }
        }

        private void numPoligono_ValueChanged(object sender, EventArgs e)
        {
            numeroLados = (int)numPoligono.Value;
            puntosPoligono = new Point[numeroLados];
        }

        private void imgActual_Click(object sender, EventArgs e)
        {

        }

        private void lblCoordenadas_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void imgActual_MouseUp(object sender, MouseEventArgs e)
        {
            estaPintando = false;
            lblStatus.Text = "No Dibujando";
            puntos = new Point[0];
            segundoPunto = new Point(e.X, e.Y);

            imgActual.Image = canvas;
            objetoDibujador = Graphics.FromImage(canvas);
            Pen miLapiz = new Pen(btnColor.BackColor, (float)numTamano.Value);
            SolidBrush brush = new SolidBrush(btnColor.BackColor);
            objetoDibujador.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            switch (figuraActiva)
            {
                case Figuras.Linea:
                    miLapiz.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    miLapiz.EndCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
                    objetoDibujador.DrawLine(miLapiz, primerPunto, segundoPunto);
                    break;
                case Figuras.Circulo:
                    if (cbxFondo.Checked == true)
                    {
                        objetoDibujador.DrawEllipse(miLapiz, (int)primerPunto.X, (int)primerPunto.Y, (int)(segundoPunto.X - primerPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                        objetoDibujador.FillEllipse(brush, (int)primerPunto.X, (int)primerPunto.Y, (int)(segundoPunto.X - primerPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                    }
                    else
                    {
                        objetoDibujador.DrawEllipse(miLapiz, (int)primerPunto.X, (int)primerPunto.Y, (int)(segundoPunto.X - primerPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                    }
                    break;
                case Figuras.Cuadrado:
                    if (cbxFondo.Checked == true)
                    {
                        if (primerPunto.X < segundoPunto.X)
                        {
                            Rectangle rect = new Rectangle((int)primerPunto.X, (int)primerPunto.Y, (int)(segundoPunto.X - primerPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                            
                            objetoDibujador.FillRectangle(brush, rect);
                            objetoDibujador.DrawRectangle(miLapiz, rect);
                        }
                        else
                        {
                            Rectangle rect = new Rectangle((int)segundoPunto.X, (int)primerPunto.Y, (int)(primerPunto.X - segundoPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                            
                            objetoDibujador.FillRectangle(brush, rect);
                            objetoDibujador.DrawRectangle(miLapiz, rect);

                        }
                    }
                    else {
                       
                        if (primerPunto.X < segundoPunto.X)
                        {
                            Rectangle rect = new Rectangle((int)primerPunto.X, (int)primerPunto.Y, (int)(segundoPunto.X - primerPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                            objetoDibujador.DrawRectangle(miLapiz, rect);
                        }
                        else
                        {
                            Rectangle rect = new Rectangle((int)segundoPunto.X, (int)primerPunto.Y, (int)(primerPunto.X - segundoPunto.X), (int)(segundoPunto.Y - primerPunto.Y));
                            objetoDibujador.DrawRectangle(miLapiz, rect);

                        }
                    }
                    
                    break;
                case Figuras.Triangulo:            
                    Point[] shape = new Point[3];
                    shape[0] = new Point(primerPunto.X, primerPunto.Y);
                    shape[1] = new Point(segundoPunto.X, segundoPunto.Y);
                    shape[2] = new Point(((primerPunto.X + segundoPunto.X)/2)+50, ((primerPunto.Y + segundoPunto.Y)/2)+50 );

                    if (cbxFondo.Checked == true)
                    {
                        objetoDibujador.DrawPolygon(miLapiz, shape);
                        objetoDibujador.FillPolygon(brush, shape);
                    }
                    else {
                        objetoDibujador.DrawPolygon(miLapiz, shape);
                    }  
                    break;
                case Figuras.Texto:
                    SolidBrush drawBrush = new SolidBrush(btnColor.BackColor);

                    PointF drawPoint = new PointF(primerPunto.X, primerPunto.Y);

                    objetoDibujador.DrawString(textoBase, drawFont, drawBrush, drawPoint);
                    break;
                default:
                    break;
            }
        }
    }
}
