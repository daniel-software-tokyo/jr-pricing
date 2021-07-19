﻿Imports Jr.Pricing.Fw
Imports Jr.Pricing.Model.Bill

Namespace Model.Discount
    Public Class Discounts : Inherits CollectionObject(Of IDiscount)

        Public Sub New()
        End Sub

        Public Sub New(src As CollectionObject(Of IDiscount))
            MyBase.New(src)
        End Sub

        Public Sub New(initialList As IEnumerable(Of IDiscount))
            MyBase.New(initialList)
        End Sub

        ''' <summary>
        ''' すべての割引ルールで計算をする
        ''' </summary>
        ''' <param name="amount"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Calculate(amount As Amount) As Amount
            Return InternalList.Aggregate(amount, Function(current, aDiscount) aDiscount.CalculateIfNecessary(current))
        End Function

    End Class
End Namespace