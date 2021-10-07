Public Class Game
    'This creates the snake as an array of pictureboxes'
    Dim snake(500) As PictureBox
    'this declares the snakelength as an integer'
    Dim intSnakelength As Integer = -1
    'This creates booleans for moving the snake'
    Dim intUpDown As Integer = 0
    Dim intLeftRight As Integer = 0
    'This tracks the amount of food collected and creates apple as a picturebox'
    Dim intFood As Integer = 0
    Dim Apple As PictureBox
    'This is an integer to be used with making random location for the apple'
    Dim applex As Integer = 0
    Dim appley As Integer = 0

    Private Sub snakehead()
        'This increases the snakelength by one each time this method is called, and creates a picturebox'

        intSnakelength += 1
        snake(intSnakelength) = New PictureBox

        'This also sets all the appropriate properties to the new snake part when the method is called'
        snake(intSnakelength).Height = 15
        snake(intSnakelength).Width = 15
        snake(intSnakelength).BackColor = Color.Red
        'This sets the starting position of the snakehead the center of the picZone)
        snake(intSnakelength).Top = (picZone.Top + picZone.Bottom) / 2
        snake(intSnakelength).Left = (picZone.Left + picZone.Right) / 2
        'This gives control to the snakehead and lets the snake be in the front of the picZone)
        Me.Controls.Add(snake(intSnakelength))
        snake(intSnakelength).BringToFront()
        'This lengths the snake by 3 body parts'
        snakelengthen()
        snakelengthen()
        snakelengthen()
    End Sub

    Private Sub Game_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'This handles the cases when A,D,W,S are clicked on keyboard and how they will move
        Select Case e.KeyChar
            Case "a"
                intLeftRight = -15
                intUpDown = 0
            Case "d"
                intLeftRight = 15
                intUpDown = 0
            Case "w"
                intUpDown = -15
                intLeftRight = 0
            Case "s"
                intUpDown = 15
                intLeftRight = 0
        End Select
    End Sub

    Private Sub Game_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'This calls the snakehead method, and enables the timer'
        snakehead()
        TimeMover.Enabled = True
        'This calls the food method'
        food()
        Hitwalls()
    End Sub

    Private Sub TimeMover_Tick(sender As System.Object, e As System.EventArgs) Handles TimeMover.Tick
        'This will move the head of the snake when the timer is enabled'
        snake(0).Top += intUpDown
        snake(0).Left += intLeftRight
        'This will move the snake body with the snakehead when the timer is enabled by moving the body parts to equal the location'
        'of the part in front of it.'
        For i = intSnakelength To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left
        Next
        'This calls method hitwalls'
        Hitwalls()
        If snake(0).Bounds.IntersectsWith(picApple.Bounds) Then
            food()
            snakelengthen()
        End If
    End Sub
    Private Sub snakelengthen()
        'This increases the integer snakelength by 1 everytime the method is called'
        intSnakelength += 1
        'Then at each snake at the index of the intsnakelength, a new picture box will be created'
        snake(intSnakelength) = New PictureBox
        'This sets the snakebody properties, at the index of snakelength to the following'
        snake(intSnakelength).Height = 15
        snake(intSnakelength).Width = 15
        snake(intSnakelength).BackColor = Color.LimeGreen
        snake(intSnakelength).Top = snake(intSnakelength - 1).Top
        snake(intSnakelength).Left = snake(intSnakelength - 1).Left + 10
        'This gives control to the snakebody and lets the snake be in front of the picZone'
        Me.Controls.Add(snake(intSnakelength))
        snake(intSnakelength).BringToFront()
    End Sub
    Private Sub food()

        'This adds to the amount of food collected'
        intFood += 1
        lblFood.Text = intFood
        'This sets the random position of food across the form each time the method is called'
        Randomize()

        appley = Rnd() * 24
        applex = Rnd() * 24

        picApple.Location = New Point(applex * 10, appley * 10)
        'This makes sure the apple doesnt spawn outside the play zone'

    End Sub
    Private Sub Hitwalls()
        'This checks if the snakehead location is outside the play area from the left'
        If snake(0).Left < picZone.Left Then
            TimeMover.Stop()
            MessageBox.Show("You Lose!")
        End If
        'This checks if the snakehead location is outside the play area from the right'
        If snake(0).Right > picZone.Right Then
            TimeMover.Stop()
            MessageBox.Show("You Lose!")
        End If
        'This checks if the snakehead location is outside the play area from the Top'
        If snake(0).Top < picZone.Top Then
            TimeMover.Stop()
            MessageBox.Show("You Lose!")
        End If
        'This checks if the snakehead location is outside the play area from the bottom'
        If snake(0).Bottom > picZone.Bottom Then
            TimeMover.Stop()
            MessageBox.Show("You Lose!")
        End If

    End Sub
End Class