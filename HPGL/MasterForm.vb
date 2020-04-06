Public Class MasterForm

    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDisplayPhysicalArea(picGraph, 960, 540, 75, 75, 708, 400)
        SetScale(-180, 180, -50, 50)

        Dim bm As New Bitmap(Xwide, Ywide)
        Dim gr As Graphics = Graphics.FromImage(bm)
        gr.Clear(Color.Black)

        Frame(gr, PenGreen)
        Axes(gr, PenGreen, 0, 0, 5, 5)
        Grid(gr, PenGreen, 0, 0, 10, 10)
        GraphTitle(gr, "HP-GL Plotter", "Arbutus Slab", 24)
        XTitle(gr, "ascisse 10°/DIV", "Verdana", 10)
        YTitle(gr, "ordinate 10/DIV", "Verdana", 10)
        XTickLabel(gr, 30, "Verdana", 7)
        YTickLabel(gr, 20, "Verdana", 7)

        Draw(gr, PenRed, 0, 0, 200, 60)
        Draw(gr, PenRed, 0, 0, 200, -60)
        Draw(gr, PenRed, 0, 0, -200, 60)
        Draw(gr, PenRed, 0, 0, -200, -60)

        Draw(gr, PenBlue, 0, 0, 200, 40)
        Draw(gr, PenBlue, 0, 0, 200, -40)
        Draw(gr, PenBlue, 0, 0, -200, 40)
        Draw(gr, PenBlue, 0, 0, -200, -40)

        Dim X, Ys, Yc, Xold, Yold As Single
        Dim pi As Single = 3.14159265
        For X = Xmin To Xmax Step 1
            Ys = 60 * Math.Sin(X * pi / 180)
            Yc = 60 * Math.Cos(X * pi / 180)
            If Xmin <> X Then Draw(gr, PenYellow, Xold, Yold, X, Ys)
            Plot(gr, Color.White, X, Yc)
            Plot(gr, Color.Aquamarine, X, Ys - Yc)
            Xold = X
            Yold = Ys
        Next




        picGraph.Image = bm
        Clipboard.SetDataObject(DirectCast(picGraph.Image.Clone, Bitmap), True)
    End Sub
End Class
