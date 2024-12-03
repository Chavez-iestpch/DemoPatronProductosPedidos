namespace DPPConsumidor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Pedidos nuevoPedidos = new Pedidos(
               contador++,
               TxtNombres.Text,
               TxtCorreo.Text
               );

            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaPedidos.Agregar(nuevoPedidos);
                }
                );
            TxtNombres.Clear();
            TxtCorreo.Clear();

        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Thread HiloConsumidor = new Thread(ProcesarUsuario);
            HiloConsumidor.Start();
        }
        private void ProcesarUsuario()
        {
            Pedidos pedidos = colaPedidos.Extraer();
            AgregarUsuarioDataGrid(Pedidos);
        }

        private void AgregarUsuarioDataGrid(Pedidos pedidos)
        {
            if (DgvUsuario.InvokeRequired)
            {
                DgvUsuario.Invoke(new Action(() =>
                {
                    DgvUsuario.Rows.Add(
                        u.Id, usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
                })
                );
            }
            else
            {
                DgvUsuario.Rows.Add(
                    usuario.Id, usuario.Nombre,
                    usuario.CorreoElectronico,
                    usuario.FechaCreacion
                    );
            }
        }
    }
    }

