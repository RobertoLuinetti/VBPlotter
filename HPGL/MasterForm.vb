Public Class MasterForm

    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDisplayPhysicalArea(picGraph, 960, 540, 75, 75, 810, 400) 'Select physical display area dedicated to plotter
        SetScale(-180, 180, -50, 50) 'Set scale in logical coordinate

        Dim bm As New Bitmap(Xwide, Ywide)            'initialize graphics step 1/3
        Dim gr As Graphics = Graphics.FromImage(bm)   'initialize graphics step 2/3
        gr.Clear(Color.Black)                         'initialize graphics step 3/3

        Frame(gr, PenGreen)                           'Draw a frame around logic area
        Axes(gr, PenGreen, 0, 0, 5, 5)                'Draw axes 
        Grid(gr, PenGreen, 0, 0, 10, 10)              'Draw a grid
        GraphTitle(gr, "VB.net Plotter by Roberto Luinetti", "Arbutus Slab", 24) 'Set Graph title
        XTitle(gr, "ascisse 10°/DIV", "Verdana", 10)                             'Set X axis title
        YTitle(gr, "ordinate 10/DIV", "Verdana", 10)                             'Set Y axis title
        XTickLabel(gr, 30, 30, "Verdana", 7)                                     'Set numeric scale on X axis
        YTickLabel(gr, 20, 10, "Verdana", 7)                                     'Set numeric scale on Y axis

        Draw(gr, PenRed, 0, 0, 200, 60)     'x2,y2 are outside of plotter area, segment will be truncate to out of horizontal plotter border
        Draw(gr, PenRed, 0, 0, 200, -60)    'x2,y2 are outside of plotter area, segment will be truncate to out of horizontal plotter border
        Draw(gr, PenRed, 0, 0, -200, 60)    'x2,y2 are outside of plotter area, segment will be truncate to out of horizontal plotter border
        Draw(gr, PenRed, 0, 0, -200, -60)   'x2,y2 are outside of plotter area, segment will be truncate to out of horizontal plotter border

        Draw(gr, PenBlue, 0, 0, 200, 40)    'x2,y2 are outside of plotter area, segment will be truncate to out of vertical plotter border
        Draw(gr, PenBlue, 0, 0, 200, -40)   'x2,y2 are outside of plotter area, segment will be truncate to out of vertical plotter border
        Draw(gr, PenBlue, 0, 0, -200, 40)   'x2,y2 are outside of plotter area, segment will be truncate to out of vertical plotter border
        Draw(gr, PenBlue, 0, 0, -200, -40)  'x2,y2 are outside of plotter area, segment will be truncate to out of vertical plotter border

        Dim X, Ys, Yc, Ys1, Xold, Yold As Single
        Dim pi As Single = 3.14159265
        For X = Xmin To Xmax Step 1
            Ys = 40 * Math.Sin(X * pi / 180)
            Ys1 = 25 * Math.Sin(X * pi / 180 * 2)
            Yc = 60 * Math.Cos(X * pi / 180)
            If Xmin <> X Then Draw(gr, PenYellow, Xold, Yold, X, Ys)  'Plot Ys function with DRAW mode (segment between previous x,y coords to actual x,y coords)
            Plot(gr, Color.White, X, Yc)                              'Plot Yc function with PLOT mode (dot to current x,y coords)
            Plot(gr, Color.YellowGreen, X, Ys - (Ys1 + Yc))
            Plot(gr, Color.White, X, Ys1)
            Xold = X
            Yold = Ys
        Next

        picGraph.Image = bm
        Clipboard.SetDataObject(DirectCast(picGraph.Image.Clone, Bitmap), True) 'Copy graph to clipboard
    End Sub
End Class
