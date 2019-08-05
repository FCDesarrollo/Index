Public Class clDocumento
    Private _dFolio As Double
    Private _dNumMoneda As Long
    Private _dTipoCambio As Double
    Private _dImporte As Double       ' Importe se asigna solamente cuando se va crear un documento de CxC o CxP, en otro su valor es cero.
    Private _dCodConcepto As String
    Private _dSerie As String
    Private _dFecha As String   ' Formato mm/dd/aaaa. Las diagonales "/" son parte del formato
    Private _dCodigoCteProv As String
    Private _dCodigoAgente As String
    Private _dReferencia As String

    Public Property DFolio As Double
        Get
            Return _dFolio
        End Get
        Set(value As Double)
            _dFolio = value
        End Set
    End Property

    Public Property DNumMoneda As Long
        Get
            Return _dNumMoneda
        End Get
        Set(value As Long)
            _dNumMoneda = value
        End Set
    End Property

    Public Property DTipoCambio As Double
        Get
            Return _dTipoCambio
        End Get
        Set(value As Double)
            _dTipoCambio = value
        End Set
    End Property

    Public Property DImporte As Double
        Get
            Return _dImporte
        End Get
        Set(value As Double)
            _dImporte = value
        End Set
    End Property

    Public Property DCodConcepto As String
        Get
            Return _dCodConcepto
        End Get
        Set(value As String)
            _dCodConcepto = value
        End Set
    End Property

    Public Property DSerie As String
        Get
            Return _dSerie
        End Get
        Set(value As String)
            _dSerie = value
        End Set
    End Property

    Public Property DFecha As String
        Get
            Return _dFecha
        End Get
        Set(value As String)
            _dFecha = value
        End Set
    End Property

    Public Property DCodigoCteProv As String
        Get
            Return _dCodigoCteProv
        End Get
        Set(value As String)
            _dCodigoCteProv = value
        End Set
    End Property

    Public Property DCodigoAgente As String
        Get
            Return _dCodigoAgente
        End Get
        Set(value As String)
            _dCodigoAgente = value
        End Set
    End Property

    Public Property DReferencia As String
        Get
            Return _dReferencia
        End Get
        Set(value As String)
            _dReferencia = value
        End Set
    End Property
End Class
