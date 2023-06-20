Imports System.Windows.Forms

Public Class RLTexter


    Private lines As String() ' Das Array mit den Zeilen
    Private currentIndex As Integer ' Der aktuelle Index im Array
    Private timer As Timer ' Der Timer
    Private label As Label ' Das Label, in dem die Zeilen angezeigt werden
    Private wordscount As Integer 'anzahl wörter
    Private status As Label 'label, was den status anzeigt


    Public Sub New(lines As String(), label As Label, statuslabel As Label)
        Me.lines = lines
        Me.label = label
        Me.status = statuslabel
        currentIndex = 0

        timer = New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub

    Public Sub Start(interval As Integer)
        If timer IsNot Nothing AndAlso Not timer.Enabled Then
            timer.Interval = interval
            label.Text = lines(currentIndex)
            currentIndex += 1


            timer.Start()
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        If currentIndex < lines.Length Then
            label.Text = lines(currentIndex)
            currentIndex += 1
            status.Text = currentIndex.ToString & " / " & lines.Count & " / " & Math.Round(currentIndex / lines.Count * 100, 2) & " %"
        Else
            timer.Stop()
        End If
    End Sub

    Public Sub StopAnimation()
        If timer IsNot Nothing AndAlso timer.Enabled Then
            timer.Stop()
        End If
    End Sub

    Public Sub UpdateInterval(interval As Integer)
        If timer IsNot Nothing Then
            timer.Interval = interval
        End If
    End Sub
End Class
