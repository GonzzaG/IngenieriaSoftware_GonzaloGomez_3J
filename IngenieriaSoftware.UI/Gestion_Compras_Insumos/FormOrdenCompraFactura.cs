using System.Windows.Forms;

namespace IngenieriaSoftware.UI.Gestion_Compras_Insumos
{
    public partial class FormOrdenCompraFactura : Form
    {
        public FormOrdenCompraFactura()
        {
            InitializeComponent();
        }

        //TODO: Agregar un campo Tipo varchar, que por defecto sea 'Restaurante', para diferenciar productos del negocio con productos
        //como packaging, limpieza, etc.
        //cambiar los procedures de producto para obtener los que son Restaurante, y cuando se inserta, sean de resturante.
        //- Orden de compra (OC)
        //        Se emite desde el área de compras al proveedor, detallando productos, cantidades, precios y condiciones.
        //        - Recepción de mercadería
        //        El encargado de depósito verifica que lo recibido coincida con la OC.Si todo está correcto, registra la recepción conforme en el sistema.
        //        - Factura del proveedor
        //        El proveedor emite la factura, generalmente después de despachar la mercadería. En algunos casos, la factura puede llegar junto con los productos o incluso antes, como anticipo.
        //        - Carga y validación de la factura
        //        El área administrativa o de cuentas a pagar registra la factura en el sistema, y la compara contra la OC y la recepción.Si todo coincide, se aprueba para pago.
        //        - Pago al proveedor
        //        Se realiza según los términos acordados (por ejemplo, a 30 días de la fecha de factura o de recepción).


    }
}
