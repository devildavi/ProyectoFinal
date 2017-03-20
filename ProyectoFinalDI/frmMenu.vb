Public Class ucPuntuacion5

    Private Sub cargarDatos(sender As Object, e As EventArgs) Handles UcPuntuacion1.Load
        jugador1()
        jugador2()
        jugador3()
        jugador4()
        jugador5()
        jugador6()
        jugador7()
        jugador8()
        jugador9()
        jugador10()
    End Sub

    Private Sub tsbPlay_Click(sender As Object, e As EventArgs) Handles tsbPlay.Click
        MediaPlayer.Ctlcontrols.play()
        tsbPlay.Image = My.Resources.Iconos.pausa

    End Sub

    Private Sub PanelMediaPlayer_DragEnter(sender As Object, e As DragEventArgs) Handles PanelMediaPlayer.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub PanelMediaPlayer_DragDrop(sender As Object, e As DragEventArgs) Handles PanelMediaPlayer.DragDrop


    End Sub

    Private Sub tsbFullScreen_Click(sender As Object, e As EventArgs) Handles tsbFullScreen.Click
        MediaPlayer.fullScreen = True
    End Sub

    Private Sub tsbDetener_Click(sender As Object, e As EventArgs) Handles tsbDetener.Click
        MediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub tsbSinVolumen_Click(sender As Object, e As EventArgs) Handles tsbSinVolumen.Click
        MediaPlayer.settings.mute = True
    End Sub

    Private Sub tsbSubirVolumen_Click(sender As Object, e As EventArgs) Handles tsbSubirVolumen.Click
        MediaPlayer.settings.volume = MediaPlayer.settings.volume + 10
    End Sub

    Private Sub tsbBajarVolumen_Click(sender As Object, e As EventArgs) Handles tsbBajarVolumen.Click
        MediaPlayer.settings.volume = MediaPlayer.settings.volume - 10
    End Sub

    Public Sub jugador1()
        UcPuntuacion1.setCampeon(My.Resources.Imagenes.shen)
        UcPuntuacion1.setNivel("13")
        UcPuntuacion1.setHechizo1(My.Resources.Imagenes.tp)
        UcPuntuacion1.setCHechizo2(My.Resources.Imagenes.flash)
        UcPuntuacion1.setKDA("2/0/5")
        UcPuntuacion1.setMinions("200")
        UcPuntuacion1.setObjeto1(My.Resources.Imagenes.guardiancontrol)
        UcPuntuacion1.setObjeto2(My.Resources.Imagenes.escudodoran)
        UcPuntuacion1.setObjeto3(My.Resources.Imagenes.botasresistencia)
        UcPuntuacion1.setObjeto4(My.Resources.Imagenes.tiamat)
        UcPuntuacion1.setObjeto5(My.Resources.Imagenes.rostroespiritual)
        UcPuntuacion1.setObjeto6(My.Resources.Imagenes.capafuegosolar)
        UcPuntuacion1.setWard(My.Resources.Imagenes.wardazul)

        UcJugador1.setFoto(My.Resources.Imagenes.vizic)
        UcJugador1.setNombre("Vizicsacsi")
        UcJugador1.setNombreReal("Tamás Kiss")
        UcJugador1.setRol("Toplaner")
        UcJugador1.setNacionalidad(My.Resources.Imagenes.hungria)
    End Sub

    Public Sub jugador2()
        UcPuntuacion2.setCampeon(My.Resources.Imagenes.graves)
        UcPuntuacion2.setNivel("11")
        UcPuntuacion2.setHechizo1(My.Resources.Imagenes.smite)
        UcPuntuacion2.setCHechizo2(My.Resources.Imagenes.flash)
        UcPuntuacion2.setKDA("1/2/1")
        UcPuntuacion2.setMinions("123")
        UcPuntuacion2.setObjeto2(My.Resources.Imagenes.cristalrubi)
        UcPuntuacion2.setObjeto3(My.Resources.Imagenes.botasresistencia)
        UcPuntuacion2.setObjeto4(My.Resources.Imagenes.bacteriofago)
        UcPuntuacion2.setObjeto5(My.Resources.Imagenes.sobremaleficios)
        UcPuntuacion2.setObjeto6(My.Resources.Imagenes.guerrero)
        UcPuntuacion2.setWard(My.Resources.Imagenes.wardquitarwards)

        UcJugador2.setFoto(My.Resources.Imagenes.xerxe)
        UcJugador2.setNombre("Xerxe")
        UcJugador2.setNombreReal("Andrei Dragomir")
        UcJugador2.setRol("Jungler")
        UcJugador2.setNacionalidad(My.Resources.Imagenes.rumania)
    End Sub

    Public Sub jugador3()
        UcPuntuacion3.setCampeon(My.Resources.Imagenes.jayce)
        UcPuntuacion3.setNivel("13")
        UcPuntuacion3.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion3.setCHechizo2(My.Resources.Imagenes.extenuacion)
        UcPuntuacion3.setKDA("0/4/2")
        UcPuntuacion3.setMinions("178")
        UcPuntuacion3.setObjeto1(My.Resources.Imagenes.espadalarga)
        UcPuntuacion3.setObjeto2(My.Resources.Imagenes.lagrima)
        UcPuntuacion3.setObjeto3(My.Resources.Imagenes.gemavida)
        UcPuntuacion3.setObjeto4(My.Resources.Imagenes.botasresistencia)
        UcPuntuacion3.setObjeto5(My.Resources.Imagenes.bacteriofago)
        UcPuntuacion3.setObjeto6(My.Resources.Imagenes.youmuu)
        UcPuntuacion3.setWard(My.Resources.Imagenes.wardnormal)

        UcJugador3.setFoto(My.Resources.Imagenes.exileh)
        UcJugador3.setNombre("Exileh")
        UcJugador3.setNombreReal("Fabian Schubert")
        UcJugador3.setRol("Midlaner")
        UcJugador3.setNacionalidad(My.Resources.Imagenes.alemania)
    End Sub

    Public Sub jugador4()
        UcPuntuacion4.setCampeon(My.Resources.Imagenes.varus)
        UcPuntuacion4.setNivel("12")
        UcPuntuacion4.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion4.setCHechizo2(My.Resources.Imagenes.curar)
        UcPuntuacion4.setKDA("1/2/1")
        UcPuntuacion4.setMinions("208")
        UcPuntuacion4.setObjeto1(My.Resources.Imagenes.galleta)
        UcPuntuacion4.setObjeto2(My.Resources.Imagenes.guardiancontrol)
        UcPuntuacion4.setObjeto3(My.Resources.Imagenes.lagrima)
        UcPuntuacion4.setObjeto4(My.Resources.Imagenes.botascdr)
        UcPuntuacion4.setObjeto5(My.Resources.Imagenes.youmuu)
        UcPuntuacion4.setObjeto6(My.Resources.Imagenes.filonoche)
        UcPuntuacion4.setWard(My.Resources.Imagenes.wardazul)

        UcJugador4.setFoto(My.Resources.Imagenes.samux)
        UcJugador4.setNombre("Samux")
        UcJugador4.setNombreReal("Samuel Fernández")
        UcJugador4.setRol("ADCarry")
        UcJugador4.setNacionalidad(My.Resources.Imagenes.españa)
    End Sub

    Public Sub jugador5()

        UcPuntuacion11.setCampeon(My.Resources.Imagenes.zyra)
        UcPuntuacion11.setNivel("10")
        UcPuntuacion11.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion11.setCHechizo2(My.Resources.Imagenes.extenuacion)
        UcPuntuacion11.setKDA("0/3/1")
        UcPuntuacion11.setMinions("16")
        UcPuntuacion11.setObjeto1(My.Resources.Imagenes.guardiancontrol)
        UcPuntuacion11.setObjeto2(My.Resources.Imagenes.cristalrubi)
        UcPuntuacion11.setObjeto3(My.Resources.Imagenes.tomoap)
        UcPuntuacion11.setObjeto4(My.Resources.Imagenes.varaap)
        UcPuntuacion11.setObjeto5(My.Resources.Imagenes.botasrapidez)
        UcPuntuacion11.setObjeto6(My.Resources.Imagenes.ojovigilantes)
        UcPuntuacion11.setWard(My.Resources.Imagenes.wardquitarwards)

        UcJugador5.setFoto(My.Resources.Imagenes.hylissang)
        UcJugador5.setNombre("Hylissang")
        UcJugador5.setNombreReal("Zdravets Galabor")
        UcJugador5.setRol("Support")
        UcJugador5.setNacionalidad(My.Resources.Imagenes.bulgaria)
    End Sub

    Public Sub jugador6()
        UcPuntuacion6.setCampeon(My.Resources.Imagenes.renekton)
        UcPuntuacion6.setNivel("15")
        UcPuntuacion6.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion6.setCHechizo2(My.Resources.Imagenes.tp)
        UcPuntuacion6.setKDA("0/0/6")
        UcPuntuacion6.setMinions("250")
        UcPuntuacion6.setObjeto1(My.Resources.Imagenes.hidratitanica)
        UcPuntuacion6.setObjeto2(My.Resources.Imagenes.cuchilla)
        UcPuntuacion6.setObjeto3(My.Resources.Imagenes.habitoespectro)
        UcPuntuacion6.setObjeto4(My.Resources.Imagenes.tabi)
        UcPuntuacion6.setObjeto5(My.Resources.Imagenes.doran)
        UcPuntuacion6.setWard(My.Resources.Imagenes.wardazul)

        UcJugador6.setFoto(My.Resources.Imagenes.alphari)
        UcJugador6.setNombre("Alphari")
        UcJugador6.setNombreReal("Barney Morris")
        UcJugador6.setRol("Toplaner")
        UcJugador6.setNacionalidad(My.Resources.Imagenes.reinounido)
    End Sub

    Public Sub jugador7()
        UcPuntuacion7.setCampeon(My.Resources.Imagenes.elise)
        UcPuntuacion7.setNivel("13")
        UcPuntuacion7.setHechizo1(My.Resources.Imagenes.smite)
        UcPuntuacion7.setCHechizo2(My.Resources.Imagenes.flash)
        UcPuntuacion7.setKDA("5/1/3")
        UcPuntuacion7.setMinions("120")
        UcPuntuacion7.setObjeto1(My.Resources.Imagenes.liandry)
        UcPuntuacion7.setObjeto2(My.Resources.Imagenes.ecosrunicos)
        UcPuntuacion7.setObjeto3(My.Resources.Imagenes.codice)
        UcPuntuacion7.setObjeto4(My.Resources.Imagenes.botascdr)
        UcPuntuacion7.setObjeto5(My.Resources.Imagenes.tomoap)
        UcPuntuacion7.setWard(My.Resources.Imagenes.wardquitarwards)

        UcJugador7.setFoto(My.Resources.Imagenes.kakao)
        UcJugador7.setNombre("KaKAO")
        UcJugador7.setNombreReal("Byung-Kwon Lee")
        UcJugador7.setRol("Jungler")
        UcJugador7.setNacionalidad(My.Resources.Imagenes.koreasur)
    End Sub

    Public Sub jugador8()
        UcPuntuacion8.setCampeon(My.Resources.Imagenes.orianna)
        UcPuntuacion8.setNivel("15")
        UcPuntuacion8.setHechizo1(My.Resources.Imagenes.fantasmal)
        UcPuntuacion8.setCHechizo2(My.Resources.Imagenes.flash)
        UcPuntuacion8.setKDA("6/0/4")
        UcPuntuacion8.setMinions("216")
        UcPuntuacion8.setObjeto1(My.Resources.Imagenes.zhonyas)
        UcPuntuacion8.setObjeto2(My.Resources.Imagenes.varaedades)
        UcPuntuacion8.setObjeto3(My.Resources.Imagenes.bastonvacio)
        UcPuntuacion8.setObjeto4(My.Resources.Imagenes.tabi)
        UcPuntuacion8.setObjeto5(My.Resources.Imagenes.anillodoran)
        UcPuntuacion8.setWard(My.Resources.Imagenes.wardnormal)

        UcJugador8.setFoto(My.Resources.Imagenes.powerofevil)
        UcJugador8.setNombre("PowerOfEvil")
        UcJugador8.setNombreReal("Tristan Schrage")
        UcJugador8.setRol("Midlaner")
        UcJugador8.setNacionalidad(My.Resources.Imagenes.alemania)
    End Sub

    Public Sub jugador9()
        UcPuntuacion9.setCampeon(My.Resources.Imagenes.jhin)
        UcPuntuacion9.setNivel("13")
        UcPuntuacion9.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion9.setCHechizo2(My.Resources.Imagenes.curar)
        UcPuntuacion9.setKDA("2/0/5")
        UcPuntuacion9.setMinions("200")
        UcPuntuacion9.setObjeto1(My.Resources.Imagenes.filonoche)
        UcPuntuacion9.setObjeto2(My.Resources.Imagenes.youmuu)
        UcPuntuacion9.setObjeto3(My.Resources.Imagenes.tabi)
        UcPuntuacion9.setObjeto4(My.Resources.Imagenes.capacritico)
        UcPuntuacion9.setWard(My.Resources.Imagenes.wardazul)

        UcJugador9.setFoto(My.Resources.Imagenes.hanssama)
        UcJugador9.setNombre("Hans Sama")
        UcJugador9.setNombreReal("Steven Liv")
        UcJugador9.setRol("AD Carry")
        UcJugador9.setNacionalidad(My.Resources.Imagenes.francia)
    End Sub

    Public Sub jugador10()
        UcPuntuacion10.setCampeon(My.Resources.Imagenes.malzahar)
        UcPuntuacion10.setNivel("11")
        UcPuntuacion10.setHechizo1(My.Resources.Imagenes.flash)
        UcPuntuacion10.setCHechizo2(My.Resources.Imagenes.extenuacion)
        UcPuntuacion10.setKDA("2/2/11")
        UcPuntuacion10.setMinions("22")
        UcPuntuacion10.setObjeto1(My.Resources.Imagenes.ojovigilantes)
        UcPuntuacion10.setObjeto2(My.Resources.Imagenes.redencion)
        UcPuntuacion10.setObjeto3(My.Resources.Imagenes.botasmovilidad)
        UcPuntuacion10.setObjeto4(My.Resources.Imagenes.mantoresistencia)
        UcPuntuacion10.setObjeto5(My.Resources.Imagenes.guardiancontrol)
        UcPuntuacion10.setObjeto6(My.Resources.Imagenes.galleta)
        UcPuntuacion10.setWard(My.Resources.Imagenes.wardquitarwards)

        UcJugador10.setFoto(My.Resources.Imagenes.ignar)
        UcJugador10.setNombre("IgNar")
        UcJugador10.setNombreReal("Dong-Geun Lee")
        UcJugador10.setRol("Support")
        UcJugador10.setNacionalidad(My.Resources.Imagenes.koreasur)
    End Sub

End Class