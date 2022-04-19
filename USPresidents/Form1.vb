Imports System.IO
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim ages(44) As Integer

        'OMITTED ORIGINAL LINES FROM YOUR CODE
        'Dim temp() As String = IO.File.ReadAllLines("AgeAtInaug.txt")

        'STORES THE NAMES IN THE FILE
        Dim names(44) As String

        'SERVES AS A COUNTER FOR THE NUMBER OF LINES READ
        Dim i As Integer = 0

        'OMITTED ORIGINAL LINES FROM YOUR CODE
        'For i As Integer = 0 To 44

        'READS EACH LINE OF THE FILE
        For Each line As String In File.ReadAllLines("AgeAtInaug.txt")
            'GETS THE NAME OF THE PRESIDENT AND STORES IN THE ARRAY names
            names(i) = line.Substring(0, line.IndexOf(","))
            'GETS THE AGE OF THE PRESIDENT AND STORES IN THE ARRAY ages
            ages(i) = Integer.Parse(line.Substring(line.IndexOf(",") + 1))
            'PRINTS OUT THE CONTENTS OF THE AGEATINAUG.TXT FILE
            lstValues.Items.Add(names(i) & ": " & ages(i))
            'ADDS 1 TO THE LINE COUNTER
            i = i + 1
        Next
        'OMITTED ORIGINAL LINES FROM YOUR CODE
        'lstValues.Items.Add(names(names.Count - 1) & ": " & ages(ages.Count - 1))
        'lstValues.Items.Add(names.First & ": " & ages.First)
        'lstValues.Items.Add(names.Last & ": " & ages.Last)

        'PRINTS OUT THE OLDEST, YOUNGEST AND AVERAGE AGES FROM FILE
        lstValues.Items.Add("Oldest Age: " & ages.Max)
        lstValues.Items.Add("Youngest Age: " & ages.Min)
        lstValues.Items.Add("Average Age: " & (ages.Sum / ages.Count))
    End Sub
End Class