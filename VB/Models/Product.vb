Imports System.Web.Mvc
Imports System.ComponentModel.DataAnnotations

Public Class Product
	Public Property ProductID() As Integer
	<Required(ErrorMessage := "Product Name is required")>
	Public Property ProductName() As String
	<Required(ErrorMessage := "Unit Price is required")>
	Public Property UnitPrice() As Decimal?
	<Required(ErrorMessage := "Units On Order are required")>
	Public Property UnitsOnOrder() As Short?
End Class