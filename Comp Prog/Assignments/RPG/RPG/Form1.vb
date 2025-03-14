﻿Imports System.IO
Public Class Form1
    Dim heroSpriteSheet As New Bitmap("FF1SpriteSheet.png")
    Dim heroChoice As Integer = 5 'Use 0 to 12 to represent the different rows in the spritesheet
    Dim back, item, tile, heroBM As Bitmap 'These store in memory the images to be drawn into the pictureboxes
    Dim MapWidth As Integer = 14        'Controls the number of tiles in each row of your map   - You can change this to match the width of your map files
    Dim MapHeight As Integer = 14       'Controls the number of tiles in each column of your map - You can change this to match the height of your map files
    Dim TileWidth As Integer = 32       'Width, in Pixels of each tile - You could change this if you wanted smaller or larger sized tiles, but I would make certain it holds the same value as TileHeight
    Dim TileHeight As Integer = 32      'Height, in Pixels of each tile - - You could change this if you wanted smaller or larger sized tiles, but I would make certain it holds the same value as TileWidth
    Dim NumLevels As Integer = 5       'Number of Levels in your Dungeon - If you increase this, you need to have both a map and imap text file for all levels or program will not be able to function
    Dim board(MapWidth, MapHeight) As PictureBox
    Dim CurrentLevel As Integer = 5   'Stores the current level of the Dungeon hero is on - We start at level 1 and it goes up when we go up stairs, it goes down when we go down stairs
    Dim map(MapWidth, MapHeight, NumLevels + 1) As String  'All of our map text files get loaded into this 3D array, which stores all background codes in (X, Y, Level)  map(3, 5, 2) stores the background texture for (3, 5) for Level 2
    Dim imap(MapWidth, MapHeight, NumLevels + 1) As String 'All of our item files get loaded into this 3D array, which stores all item codes in (X, Y, Level)  imap(10, 7, 5) stores the item texture for (10, 7) for Level 5
    Dim x, y, z As Integer             'Use in for loops to set starting values
    Dim hero As PictureBox          'our hero!
    Dim HeroX, HeroY As Integer   'Keeps track of Hero's current (X,Y) position on board
    Dim NumKeys As Integer = 0    'Number of keys the hero currently holds
    Dim numSwords As Integer = 0
    Dim HeroDirection As String   'Direction the hero is moving in
    Dim MapFileName As String       'Stores the filename of our map text files.  Make sure all map files are saved as "mapx.txt", where x is the level
    Dim ItemFileName As String       'Stores the filename of our item text files.  Make sure all item files are saved as "imapx.txt", where x is the level
    Dim Mapfiles(NumLevels + 1) As StreamReader 'We use StreamReader to read our various map text files.  We create an array of streamreaders, since each one holds a different map file
    Dim ItemFiles(NumLevels + 1) As StreamReader  'We use StreamReader to read our various item text files.  We create an array of streamreaders, since each one holds a different item file
    Dim row As Integer
    Dim impassable As New List(Of String)
    Dim potion, foodnum As Integer
    '  Dim heroSpriteSheet As Bitmap
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(TileWidth * MapWidth + 16, TileHeight * MapHeight + 40)
        changeHeroBitMap()
        addImpassableTextures()
        LoadMapsAndItems()  'Loads all map files and items files into the map and imap Arrays
        LoadHero()          'Creates our hero picturebox and places him at (1,1)
        DrawLevel()         'Draws both background and items pictureboxes
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        '************************* Here you can add different image files for when he moves in different directions and add code for taking alternating steps using two image files for each direction
        If e.KeyCode = Keys.K Then              'K messageboxes the number of keys you currently have
            MsgBox("You have " & NumKeys & " keys.")
        ElseIf e.KeyCode = Keys.W Then
            If isPassable(map(HeroX, HeroY - 1, CurrentLevel)) Then   'Move hero up if the tile above him isn't a wall
                HeroY = HeroY - 1
                HeroDirection = "up"
                row = 4
            End If
        ElseIf e.KeyCode = Keys.S Then
            If isPassable(map(HeroX, HeroY + 1, CurrentLevel)) Then  'Move hero down if the tile above him isn't a wall
                HeroY = HeroY + 1
                HeroDirection = "down"
                row = 0
            End If
        ElseIf e.KeyCode = Keys.A Then
            If isPassable(map(HeroX - 1, HeroY, CurrentLevel)) Then    'Move hero left if the tile to his left isn't a wall
                HeroX = HeroX - 1
                row = 2
                HeroDirection = "left"
            End If
        ElseIf e.KeyCode = Keys.D Then
            If isPassable(map(HeroX + 1, HeroY, CurrentLevel)) Then   'Move hero right if the tile to his right isn't a wall
                HeroX = HeroX + 1
                HeroDirection = "right"
                row = 2
            End If
        End If
        changeHeroBitMap()
        CheckItems()  'Check to see if he hit any items (keys, doors, stairs, etc..)    'Check to see if he interacts with an item after everymove
    End Sub
    Public Sub addImpassableTextures()
        impassable.Add("w")   'No walking through wall textures
        impassable.Add("t")
        impassable.Add("W")
        impassable.Add("i")
    End Sub
    Public Function isPassable(ByVal mapTexture As String) As Boolean
        For x = 0 To impassable.Count - 1
            If impassable.Item(x) = mapTexture Then Return False
        Next
        Return True
    End Function
    Public Sub changeHeroBitMap() 'Creates the hero bitmap (HeroBM) based on the tile size and direction the hero is facing
        heroBM = New Bitmap(TileWidth, TileHeight)
        Using FrameGraphics As Graphics = Graphics.FromImage(heroBM)
            FrameGraphics.DrawImage(heroSpriteSheet, New Rectangle(0, 0, TileWidth, TileHeight), New Rectangle(row * 20, heroChoice * 20, 16, 16), GraphicsUnit.Pixel)
        End Using
        If HeroDirection = "right" Then  'there is no right facing images, so flip the left ones horizontally
            heroBM.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If
    End Sub
    Private Sub LoadMapsAndItems()  'Don't Change this
        For Me.z = 1 To NumLevels
            x = 0
            y = 0
            MapFileName = "map" & z & ".txt"
            Mapfiles(z) = New StreamReader(MapFileName)
            Using Mapfiles(z)
                Do While Mapfiles(z).Peek() >= 0
                    For Each m As String In Mapfiles(z).ReadLine
                        map(x, y, z) = m
                        x += 1
                    Next
                    y += 1
                    x = 0
                Loop
            End Using
            Mapfiles(z).Close()
        Next

        For Me.z = 1 To NumLevels
            x = 0
            y = 0
            ItemFileName = "imap" & z & ".txt"
            ItemFiles(z) = New StreamReader(ItemFileName)
            Using ItemFiles(z)
                Do While ItemFiles(z).Peek() >= 0
                    For Each i As String In ItemFiles(z).ReadLine
                        imap(x, y, z) = i
                        x += 1
                    Next
                    y += 1
                    x = 0
                Loop
            End Using
            ItemFiles(z).Close()
        Next
    End Sub
    Private Sub DrawLevel()
        'Load background bitmaps
        For Me.x = 0 To MapWidth - 1
            For Me.y = 0 To MapHeight - 1
                board(x, y) = New PictureBox
                board(x, y).Size = New Size(TileWidth, TileHeight)
                board(x, y).Location = New Point(x * TileWidth, y * TileHeight)
                Controls.Add(board(x, y))
                updateLocation(x, y) 'This will combine the background bitmap with the item bitmap to create picturebox image
            Next
        Next
    End Sub
    Private Sub LoadHero()  'Only change you might make would be to change the image to your own hero
        HeroX = 1
        HeroY = 1
        hero = New PictureBox
        hero.Size = New Size(TileWidth, TileHeight)
        hero.Location = New Point(HeroX * TileWidth, HeroY * TileHeight)
        hero.Visible = True
        Controls.Add(hero)
        hero.BringToFront()
    End Sub
    Private Sub MoveHeroBack()  'This method is used to move the hero back where he came from, used for example, when hitting a door and having no keys, shouldn't be a reason to change this
        If HeroDirection = "up" Then
            HeroY = HeroY + 1
        ElseIf HeroDirection = "down" Then
            HeroY = HeroY - 1
        ElseIf HeroDirection = "left" Then
            HeroX = HeroX + 1
        ElseIf HeroDirection = "right" Then
            HeroX = HeroX - 1
        End If
        hero.Location = New Point(HeroX * TileWidth, HeroY * TileHeight)
    End Sub
    Private Sub updateLocation(ByVal x As Integer, ByVal y As Integer)
        'Background Images
        '''''''''''''''''''''''''''''''''''''''IMPLEMENT
        If map(x, y, CurrentLevel) = "g" Then
            back = New Bitmap(Image.FromFile("grass.png"), New Size(TileWidth, TileHeight))
        ElseIf map(x, y, CurrentLevel) = "w" Then
            back = New Bitmap(Image.FromFile("wall.png"), New Size(TileWidth, TileHeight))
        ElseIf map(x, y, CurrentLevel) = "i" Then
            back = New Bitmap(Image.FromFile("ice.png"), New Size(TileWidth, TileHeight))
        ElseIf map(x, y, CurrentLevel) = "t" Then
            back = New Bitmap(Image.FromFile("tree.png"), New Size(TileWidth, TileHeight))
        ElseIf map(x, y, CurrentLevel) = "W" Then
            back = New Bitmap(Image.FromFile("water.png"), New Size(TileWidth, TileHeight))
        ElseIf map(x, y, CurrentLevel) = "e" Then
            back = New Bitmap(Image.FromFile("exit.png"), New Size(TileWidth, TileHeight))
            'Add more ElseIf statements for more background choices
        Else
            back = New Bitmap(Image.FromFile("blank.png"), New Size(TileWidth, TileHeight))
        End If
        'load item bitmaps
        If imap(x, y, CurrentLevel) = "k" Then
            item = New Bitmap(Image.FromFile("key.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "l" Then
            item = New Bitmap(Image.FromFile("door.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "u" Then
            item = New Bitmap(Image.FromFile("stairsup.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "b" Then
            item = New Bitmap(Image.FromFile("block.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "m" Then
            item = New Bitmap(Image.FromFile("orc.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "d" Then
            item = New Bitmap(Image.FromFile("stairsdown.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "s" Then
            item = New Bitmap(Image.FromFile("sword2.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "y" Then
            item = New Bitmap(Image.FromFile("yellowpotion.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "o" Then
            item = New Bitmap(Image.FromFile("gold.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "i" Then
            item = New Bitmap(Image.FromFile("ice.png"), New Size(TileWidth, TileHeight))
        ElseIf imap(x, y, CurrentLevel) = "e" Then
            item = New Bitmap(Image.FromFile("exit.png"), New Size(TileWidth, TileHeight))
            'Add more elseifs for more item choices
        Else
            item = New Bitmap(Image.FromFile("blank.png"), New Size(TileWidth, TileHeight))
            '***************** Here is where you will add additional items to your RPG game *********************
            'Add elseIf statements for other item codes and images you want to appear in your maze
            'Make sure you use a unique character for each new item  ("m" for monster perhaps or "f" for fire)
            'Make sure you place the image files in the debug folder
        End If

        'Draw the map location
        tile = New Bitmap(TileWidth, TileHeight)
        Dim GR As Graphics = Graphics.FromImage(tile)
        GR.DrawImage(back, 0, 0)
        GR.DrawImage(item, 0, 0)
        board(x, y).Image = tile

        'Draw the hero
        tile = New Bitmap(TileWidth, TileHeight)
        Dim GR2 As Graphics = Graphics.FromImage(tile)
        GR2.DrawImage(back, 0, 0)
        GR2.DrawImage(heroBM, 0, 0)
        hero.Image = tile
        hero.Location = New Point(HeroX * TileWidth, HeroY * TileHeight)
    End Sub
    Private Sub CheckItems()    'This subroutine tells the program what to do when the hero hits a specific item.
        If imap(HeroX, HeroY, CurrentLevel) = "k" Then  'k means key, so we add 1 to numKeys and change the k to an n so it won't draw it next time the level loads and won't add to numkeys when we bext walk over it, we also make the tile invisible so we don't see it anymore
            NumKeys = NumKeys + 1
            imap(HeroX, HeroY, CurrentLevel) = "n"
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "b" And NumKeys = 0 Then  'If I hit a "l" (Locked door) and I don't have any keys, move me back
            MsgBox("You Win so now leave")
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "l" And NumKeys = 0 Then  'If I hit a "l" (Locked door) and I don't have any keys, move me back
            MoveHeroBack()
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "l" And NumKeys > 0 Then 'if I hit a locked door and I have at least 1 key, subtract 1 key and change the "l" to "n" (nothing) and make it invisible
            NumKeys = NumKeys - 1
            imap(HeroX, HeroY, CurrentLevel) = "n"
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "u" Then  'u means an up stairs, so add one to my Currentlevel, erase the current level and load the new background and items for the level above (CurrentLevel + 1)
            CurrentLevel = CurrentLevel + 1
            clearBackgroundAndItems()
            DrawLevel()
            hero.BringToFront()
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "d" Then 'd means down starts so subtract one from CurrentLevel, erase the current level and load the new background and items for the level below (CurrentLevel - 1)
            CurrentLevel = CurrentLevel - 1
            clearBackgroundAndItems()
            DrawLevel()
            hero.BringToFront()
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "e" Then
            MsgBox("You Win so now leave")
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "s" Then
            numSwords += 1
            imap(HeroX, HeroY, CurrentLevel) = "n"
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "m" And numSwords = 0 Then
            MoveHeroBack()
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "m" And numSwords > 0 Then
            numSwords -= 1
            imap(HeroX, HeroY, CurrentLevel) = "n"
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "y" Then
            potion += 1
            heroChoice = 7
            imap(HeroX, HeroY, CurrentLevel) = "n"
        ElseIf imap(HeroX, HeroY, CurrentLevel) = "f" And numSwords > 0 Then
            foodnum += 1
            imap(HeroX, HeroY, CurrentLevel) = "n"
            '***************** Here is where you will add additional items interactions to your RPG game *********************
            'Add elseIf statements for other item codes how you want the program to react.
            'You could add sword objects that are kept track of it your inventory like keys
            'You could add monster objects that can only be killed with swords (each monster killed subracts 1 sword
            'You could have different color keys for different color doors
            'You could have levers and gates
            'This is where your imagine gets to come into play
        End If
        updateLocation(HeroX, HeroY)
    End Sub
    Private Sub clearBackgroundAndItems() ' Don't change anything here, it erases the current board of pictureboxes so we can load new ones when we go up or down a level
        For Me.x = 0 To MapWidth - 1
            For Me.y = 0 To MapHeight - 1
                board(x, y).Dispose()
                board(x, y) = Nothing
            Next
        Next
    End Sub
End Class