Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'длина 
        Dim length As String
        ' высота
        Dim height As String
        ' ширина
        Dim weight As String

        Dim windowCount As String
        Dim windowHeight As String
        Dim windowLength As String


        Dim doorCount As String
        Dim doorHeight As String
        Dim doorLength As String

        'площадь  пола
        Dim _square As Double

        'площадь  стен
        Dim _squareWall As Double

        ' периметр
        Dim _perimetr As Double

        ' площадь 1 окнo 
        Dim _windowSquare As Double
        ' gплощадь все окон 
        Dim _windowSquares As Double

        length = TextBox1.Text
        weight = TextBox2.Text
        height = TextBox3.Text

        _windowSquare = 0

        _perimetr = 0
        _squareWall = 0
        _square = 0


        'проверк на пустое значение 
        If (String.IsNullOrEmpty(length)) Then
            MessageBox.Show("Невiрне значення для поля довжина")
            Return ' не выполнять дальнейших вычислений
        End If

        If (String.IsNullOrEmpty(weight)) Then
            MessageBox.Show("Невiрне значення для поля ширина")
            Return
        End If

        If (String.IsNullOrEmpty(height)) Then
            MessageBox.Show("Невiрне значення для поля висота")
            Return
        End If

        Dim h, w, l As Double

        Dim convertResult As Boolean = Double.TryParse(height, h)
        If (convertResult = False Or h <= 0) Then
            MessageBox.Show("Невiрне значення для поля висота")
            Return
        End If

        convertResult = Double.TryParse(weight, w)
        If (convertResult = False Or w <= 0) Then
            MessageBox.Show("Невiрне значення для поля ширина")
            Return
        End If

        convertResult = Double.TryParse(length, l)
        If (convertResult = False Or l <= 0) Then
            MessageBox.Show("Невiрне значення для поля довжина")
            Return
        End If

        ' окна 
        Dim _windowCount As Int32
        Dim _windowHeight As Int32
        Dim _windowLength As Int32

        'двери 
        Dim _doorCount As Int32
        Dim _doorHeight As Int32
        Dim _doorLength As Int32

        windowCount = TextBox4.Text
        _windowSquare = 0
        _windowSquares = 0

        ' если корректное значение которое можно преобразовать в число 
        ' t.e если введено коррекное значение в поле количество окон 

        If (Int32.TryParse(windowCount, _windowCount)) Then

            If (windowCount > 0) Then
                windowLength = TextBox5.Text

                Dim result As Boolean = Double.TryParse(windowLength, _windowLength)
                If (result = False) Then
                    MessageBox.Show("Невiрне значення для поля довжина вiкна")
                End If

                windowHeight = TextBox6.Text

                result = Double.TryParse(windowHeight, _windowHeight)
                If (result = False) Then
                    MessageBox.Show("Невiрне значення для поля висота вiкна")
                End If

                ' площадь одного 
                _windowSquare = _windowHeight * _windowLength
                ' все 
                _windowSquares = _windowSquare * _windowCount
            End If
        End If


        ' ------------------------------------- двери 
        doorCount = TextBox7.Text
        Dim _doorSquare, _doorSquares As Double

        _doorSquare = 0
        _doorSquares = 0

        ' если корректное значение которое можно преобразовать в число 
        ' t.e если введено коррекное значение в поле количество окон 

        If (Int32.TryParse(doorCount, _doorCount)) Then

            If (windowCount > 0) Then
                doorLength = TextBox8.Text

                Dim result As Boolean = Double.TryParse(doorLength, _doorLength)
                If (result = False) Then
                    MessageBox.Show("Невiрне значення для поля довжина дверей")
                End If

                doorHeight = TextBox9.Text

                result = Double.TryParse(doorHeight, _doorHeight)
                If (result = False) Then
                    MessageBox.Show("Невiрне значення для поля висота дверей")
                End If

                ' площадь одного 
                _doorSquare = _doorHeight * _doorLength
                ' все 
                _doorSquares = _doorSquare * _doorCount
            End If
        End If

        'загальна площа 
        ' переметр 
        _perimetr = 2 * (w + l)
        _square = w * l


        TextBox10.Text = _perimetr.ToString()
        'площадь пола 
        TextBox11.Text = _square.ToString()
        'площадь стен  ширина умножить на высоту  + длина умножить на высоту и так 2 раза  минус площадь окон и дверей
        _squareWall = 2 * (h * l + h * w) - _doorSquares - _windowSquares

        TextBox12.Text = _squareWall.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' The user wants to exit the application. Close everything down.
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
        TextBox6.Text = String.Empty
        TextBox7.Text = String.Empty
        TextBox8.Text = String.Empty
        TextBox9.Text = String.Empty
        TextBox10.Text = String.Empty
        TextBox11.Text = String.Empty
        TextBox12.Text = String.Empty
    End Sub
End Class
