Imports System.IO
Imports System.Text

Module MyCountModule
    Public Count As Integer
End Module

Public Class Form1
    Public FilteredMyStringBuilder As StringBuilder

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Count = 1
    End Sub

    Private Sub ChooseBase64FileBTN_Click(sender As Object, e As EventArgs) Handles ChooseBase64FileBTN.Click
        Base64FileSelector.ShowDialog()
        Dim Base64StringArray As String() = File.ReadAllLines(Base64FileSelector.FileName)
        Dim ByteArray As Byte() = New Byte() {}
        Dim UnicodeString As String = ""
        Dim LoopCount As Integer = 0
        While LoopCount < Base64StringArray.Length
            ByteArray = Convert.FromBase64String(Base64StringArray(LoopCount))
            UnicodeString = Encoding.UTF8.GetString(ByteArray)
            OutputBox.Items.Add(UnicodeString)
            LoopCount += 1
        End While
        MessageBox.Show("Done")
    End Sub

    Private Sub RemoveRangeBTN_Click(sender As Object, e As EventArgs) Handles RemoveRangeBTN.Click
        If RemoveFromPositionTB.Text <> Nothing And RemoveFromPositionTB.Text <> "" And RemoveEndAtPositionTB.Text <> Nothing And RemoveEndAtPositionTB.Text <> "" Then
            Dim StartPosition As Integer = Integer.Parse(RemoveFromPositionTB.Text)
            Dim EndPosition As Integer = Integer.Parse(RemoveEndAtPositionTB.Text)
            Dim Difference As Integer = 0
            Dim LoopCount As Integer = 1
            Difference = EndPosition - StartPosition
            While LoopCount <= Difference
                OutputBox.Items.RemoveAt(StartPosition)
                LoopCount += 1
            End While
            OutputBox.Refresh()
            MessageBox.Show("Specific items have been removed from output box", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub ExportFilterResults()
        Dim objStreamWriter As StreamWriter
        Dim StringPath As String = ExportFilteredListToSelectedFolder.SelectedPath
        If File.Exists(StringPath + "\UTF8Lists1.txt") Then
            While File.Exists(StringPath + "\UTF8Lists" + Count.ToString() + ".txt") = True
                Count += 1
            End While
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists" + Count.ToString() + ".txt")
            objStreamWriter.WriteLine(FilteredMyStringBuilder.ToString)
            objStreamWriter.Close()
        Else
            objStreamWriter = New StreamWriter(StringPath + "\UTF8Lists1.txt")
            objStreamWriter.WriteLine(FilteredMyStringBuilder.ToString)
            objStreamWriter.Close()
        End If
        FilteredMyStringBuilder = New StringBuilder()
    End Sub

    Private Sub OutputBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputBox.SelectedIndexChanged
        MessageBox.Show(OutputBox.SelectedIndex)
    End Sub

    Private Sub FilterExportBTN_Click(sender As Object, e As EventArgs) Handles FilterExportBTN.Click
        ExportFilteredListToSelectedFolder.ShowDialog()
        FilteredMyStringBuilder = New StringBuilder()
        Dim UTF8Bytes As Byte() = New Byte() {}
        Dim TotalCount As Integer = OutputBox.Items.Count
        Dim LoopCount As Integer = 0
        While LoopCount < TotalCount
            UTF8Bytes = Encoding.UTF8.GetBytes(OutputBox.Items(LoopCount).ToString())
            FilteredMyStringBuilder.Append(Convert.ToBase64String(UTF8Bytes) + Environment.NewLine)
            LoopCount += 1
        End While
        ExportFilterResults()
        MessageBox.Show("Done")
    End Sub
End Class
