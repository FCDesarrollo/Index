Public Class clDocMovimientos
    Private _mConsecutivo As Long  ' Valor inicial debe ser 100 con incrementos de 100 en 100, por si es necesario insertar movtos intermedios
    Private _mUnidades As Double   ' En caso de producto con series, lotes y/o pedimentos y carcateristicas este valor es cero
    Private _mPrecio As Double     ' Usado para docuementos de venta
    Private _mCosto As Double      ' Usado para docuemtnos de compra y/o inventarios
    Private _mCodProdSer As String
    Private _mCodAlmacen As String
    Private _mReferencia As String
    Private _mCodClasificacion As String

    Public Property MConsecutivo As Long
        Get
            Return _mConsecutivo
        End Get
        Set(value As Long)
            _mConsecutivo = value
        End Set
    End Property

    Public Property MUnidades As Double
        Get
            Return _mUnidades
        End Get
        Set(value As Double)
            _mUnidades = value
        End Set
    End Property

    Public Property MPrecio As Double
        Get
            Return _mPrecio
        End Get
        Set(value As Double)
            _mPrecio = value
        End Set
    End Property

    Public Property MCosto As Double
        Get
            Return _mCosto
        End Get
        Set(value As Double)
            _mCosto = value
        End Set
    End Property

    Public Property MCodProdSer As String
        Get
            Return _mCodProdSer
        End Get
        Set(value As String)
            _mCodProdSer = value
        End Set
    End Property

    Public Property MCodAlmacen As String
        Get
            Return _mCodAlmacen
        End Get
        Set(value As String)
            _mCodAlmacen = value
        End Set
    End Property

    Public Property MReferencia As String
        Get
            Return _mReferencia
        End Get
        Set(value As String)
            _mReferencia = value
        End Set
    End Property

    Public Property MCodClasificacion As String
        Get
            Return _mCodClasificacion
        End Get
        Set(value As String)
            _mCodClasificacion = value
        End Set
    End Property
End Class
