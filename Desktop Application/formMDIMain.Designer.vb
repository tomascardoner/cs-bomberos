<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDIMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMDIMain))
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.labelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelUsuarioNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menustripMain = New System.Windows.Forms.MenuStrip()
        Me.menuitemArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_CerrarSesion = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_Salir = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDebug = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaMosaicoHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaMosaicoVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaCascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaOrganizarIconos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaSeparadorCerrarTodas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemVentanaCerrarTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaEncajarEnVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentanaSeparadorListaVentanas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAyuda_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonTablas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemTablas_NivelesEstudio = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Parentescos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_MotivosBajaPersonas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Cargos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_CargosJerarquias = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_TiposVehiculo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_CausalesLicenciaPersonas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_TiposSancion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Cursos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_NivelesCapacitacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_TiposCapacitacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_ConceptosCalificacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SeparadorUnidades = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemTablas_TiposUnidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_UsosUnidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_MotivosBajaUnidad = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SeparadorInventario = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemTablas_Rubros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SubRubros = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Areas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Ubicaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SubUbicaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SeparadorUsuarios = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemTablas_GruposUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_SeparadorAlarmas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemTablas_Alarmas = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonPersonas = New System.Windows.Forms.ToolStripButton()
        Me.buttonUnidades = New System.Windows.Forms.ToolStripButton()
        Me.buttonInventario = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemInventario_Elementos = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonReportes = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain.SuspendLayout()
        Me.menustripMain.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelStatus, Me.labelUsuarioNombre})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 513)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(928, 22)
        Me.statusstripMain.TabIndex = 2
        '
        'labelStatus
        '
        Me.labelStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(913, 17)
        Me.labelStatus.Spring = True
        '
        'labelUsuarioNombre
        '
        Me.labelUsuarioNombre.Name = "labelUsuarioNombre"
        Me.labelUsuarioNombre.Size = New System.Drawing.Size(0, 17)
        '
        'menustripMain
        '
        Me.menustripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo, Me.menuitemDebug, Me.menuitemVentana, Me.menuitemAyuda})
        Me.menustripMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripMain.MdiWindowListItem = Me.menuitemVentana
        Me.menustripMain.Name = "menustripMain"
        Me.menustripMain.Size = New System.Drawing.Size(928, 24)
        Me.menustripMain.TabIndex = 0
        '
        'menuitemArchivo
        '
        Me.menuitemArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo_Opciones, Me.menuitemArchivo_Separador_CerrarSesion, Me.menuitemArchivo_CerrarSesion, Me.menuitemArchivo_Separador_Salir, Me.menuitemArchivo_Salir})
        Me.menuitemArchivo.Name = "menuitemArchivo"
        Me.menuitemArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuitemArchivo.Text = "&Archivo"
        '
        'menuitemArchivo_Opciones
        '
        Me.menuitemArchivo_Opciones.Name = "menuitemArchivo_Opciones"
        Me.menuitemArchivo_Opciones.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Opciones.Text = "Opciones"
        '
        'menuitemArchivo_Separador_CerrarSesion
        '
        Me.menuitemArchivo_Separador_CerrarSesion.Name = "menuitemArchivo_Separador_CerrarSesion"
        Me.menuitemArchivo_Separador_CerrarSesion.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_CerrarSesion
        '
        Me.menuitemArchivo_CerrarSesion.Name = "menuitemArchivo_CerrarSesion"
        Me.menuitemArchivo_CerrarSesion.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_CerrarSesion.Text = "Cerrar sesión del Usuario"
        '
        'menuitemArchivo_Separador_Salir
        '
        Me.menuitemArchivo_Separador_Salir.Name = "menuitemArchivo_Separador_Salir"
        Me.menuitemArchivo_Separador_Salir.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_Salir
        '
        Me.menuitemArchivo_Salir.Name = "menuitemArchivo_Salir"
        Me.menuitemArchivo_Salir.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Salir.Text = "&Salir"
        '
        'menuitemDebug
        '
        Me.menuitemDebug.Name = "menuitemDebug"
        Me.menuitemDebug.Size = New System.Drawing.Size(54, 20)
        Me.menuitemDebug.Text = "Debug"
        Me.menuitemDebug.Visible = False
        '
        'menuitemVentana
        '
        Me.menuitemVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemVentanaMosaicoHorizontal, Me.menuitemVentanaMosaicoVertical, Me.menuitemVentanaCascada, Me.menuitemVentanaOrganizarIconos, Me.menuitemVentanaSeparadorCerrarTodas, Me.menuitemVentanaCerrarTodas, Me.menuitemVentanaEncajarEnVentana, Me.menuitemVentanaSeparadorListaVentanas})
        Me.menuitemVentana.Name = "menuitemVentana"
        Me.menuitemVentana.Size = New System.Drawing.Size(61, 20)
        Me.menuitemVentana.Text = "&Ventana"
        '
        'menuitemVentanaMosaicoHorizontal
        '
        Me.menuitemVentanaMosaicoHorizontal.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_HORIZONTALLY
        Me.menuitemVentanaMosaicoHorizontal.Name = "menuitemVentanaMosaicoHorizontal"
        Me.menuitemVentanaMosaicoHorizontal.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal"
        '
        'menuitemVentanaMosaicoVertical
        '
        Me.menuitemVentanaMosaicoVertical.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_VERTICALLY
        Me.menuitemVentanaMosaicoVertical.Name = "menuitemVentanaMosaicoVertical"
        Me.menuitemVentanaMosaicoVertical.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaMosaicoVertical.Text = "Mosaico &Vertical"
        '
        'menuitemVentanaCascada
        '
        Me.menuitemVentanaCascada.Name = "menuitemVentanaCascada"
        Me.menuitemVentanaCascada.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaCascada.Text = "&Cascada"
        '
        'menuitemVentanaOrganizarIconos
        '
        Me.menuitemVentanaOrganizarIconos.Name = "menuitemVentanaOrganizarIconos"
        Me.menuitemVentanaOrganizarIconos.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaOrganizarIconos.Text = "&Organizar Iconos"
        '
        'menuitemVentanaSeparadorCerrarTodas
        '
        Me.menuitemVentanaSeparadorCerrarTodas.Name = "menuitemVentanaSeparadorCerrarTodas"
        Me.menuitemVentanaSeparadorCerrarTodas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemVentanaCerrarTodas
        '
        Me.menuitemVentanaCerrarTodas.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_CLOSE_ALL
        Me.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas"
        Me.menuitemVentanaCerrarTodas.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaCerrarTodas.Text = "Cerrar todas"
        '
        'menuitemVentanaEncajarEnVentana
        '
        Me.menuitemVentanaEncajarEnVentana.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_FIT_SIZE
        Me.menuitemVentanaEncajarEnVentana.Name = "menuitemVentanaEncajarEnVentana"
        Me.menuitemVentanaEncajarEnVentana.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentanaEncajarEnVentana.Text = "Encajar en ventana"
        '
        'menuitemVentanaSeparadorListaVentanas
        '
        Me.menuitemVentanaSeparadorListaVentanas.Name = "menuitemVentanaSeparadorListaVentanas"
        Me.menuitemVentanaSeparadorListaVentanas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemAyuda
        '
        Me.menuitemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAyuda_AcercaDe})
        Me.menuitemAyuda.Name = "menuitemAyuda"
        Me.menuitemAyuda.Size = New System.Drawing.Size(53, 20)
        Me.menuitemAyuda.Text = "A&yuda"
        '
        'menuitemAyuda_AcercaDe
        '
        Me.menuitemAyuda_AcercaDe.Name = "menuitemAyuda_AcercaDe"
        Me.menuitemAyuda_AcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.menuitemAyuda_AcercaDe.Text = "&Acerca de..."
        '
        'toolstripMain
        '
        Me.toolstripMain.AllowMerge = False
        Me.toolstripMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonTablas, Me.buttonPersonas, Me.buttonUnidades, Me.buttonInventario, Me.buttonReportes})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 24)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(109, 489)
        Me.toolstripMain.TabIndex = 1
        Me.toolstripMain.Text = "Principal"
        '
        'dropdownbuttonTablas
        '
        Me.dropdownbuttonTablas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemTablas_NivelesEstudio, Me.menuitemTablas_Parentescos, Me.menuitemTablas_MotivosBajaPersonas, Me.menuitemTablas_Cargos, Me.menuitemTablas_CargosJerarquias, Me.menuitemTablas_TiposVehiculo, Me.menuitemTablas_CausalesLicenciaPersonas, Me.menuitemTablas_TiposSancion, Me.menuitemTablas_Cursos, Me.menuitemTablas_NivelesCapacitacion, Me.menuitemTablas_TiposCapacitacion, Me.menuitemTablas_ConceptosCalificacion, Me.menuitemTablas_SeparadorUnidades, Me.menuitemTablas_TiposUnidad, Me.menuitemTablas_UsosUnidad, Me.menuitemTablas_MotivosBajaUnidad, Me.menuitemTablas_SeparadorInventario, Me.menuitemTablas_Rubros, Me.menuitemTablas_SubRubros, Me.menuitemTablas_Areas, Me.menuitemTablas_Ubicaciones, Me.menuitemTablas_SubUbicaciones, Me.menuitemTablas_SeparadorUsuarios, Me.menuitemTablas_GruposUsuario, Me.menuitemTablas_Usuarios, Me.menuitemTablas_Permisos, Me.menuitemTablas_SeparadorAlarmas, Me.menuitemTablas_Alarmas})
        Me.dropdownbuttonTablas.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_TABLAS_32
        Me.dropdownbuttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dropdownbuttonTablas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dropdownbuttonTablas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonTablas.Name = "dropdownbuttonTablas"
        Me.dropdownbuttonTablas.Size = New System.Drawing.Size(106, 36)
        Me.dropdownbuttonTablas.Text = "Tablas"
        '
        'menuitemTablas_NivelesEstudio
        '
        Me.menuitemTablas_NivelesEstudio.Name = "menuitemTablas_NivelesEstudio"
        Me.menuitemTablas_NivelesEstudio.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_NivelesEstudio.Text = "Niveles de estudio"
        '
        'menuitemTablas_Parentescos
        '
        Me.menuitemTablas_Parentescos.Name = "menuitemTablas_Parentescos"
        Me.menuitemTablas_Parentescos.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Parentescos.Text = "Parentescos"
        '
        'menuitemTablas_MotivosBajaPersonas
        '
        Me.menuitemTablas_MotivosBajaPersonas.Name = "menuitemTablas_MotivosBajaPersonas"
        Me.menuitemTablas_MotivosBajaPersonas.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_MotivosBajaPersonas.Text = "Motivos de baja de personas"
        '
        'menuitemTablas_Cargos
        '
        Me.menuitemTablas_Cargos.Name = "menuitemTablas_Cargos"
        Me.menuitemTablas_Cargos.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Cargos.Text = "Cargos"
        '
        'menuitemTablas_CargosJerarquias
        '
        Me.menuitemTablas_CargosJerarquias.Name = "menuitemTablas_CargosJerarquias"
        Me.menuitemTablas_CargosJerarquias.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_CargosJerarquias.Text = "Jerarquías"
        '
        'menuitemTablas_TiposVehiculo
        '
        Me.menuitemTablas_TiposVehiculo.Name = "menuitemTablas_TiposVehiculo"
        Me.menuitemTablas_TiposVehiculo.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_TiposVehiculo.Text = "Tipos de vehículo"
        '
        'menuitemTablas_CausalesLicenciaPersonas
        '
        Me.menuitemTablas_CausalesLicenciaPersonas.Name = "menuitemTablas_CausalesLicenciaPersonas"
        Me.menuitemTablas_CausalesLicenciaPersonas.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_CausalesLicenciaPersonas.Text = "Causales de licencia"
        '
        'menuitemTablas_TiposSancion
        '
        Me.menuitemTablas_TiposSancion.Name = "menuitemTablas_TiposSancion"
        Me.menuitemTablas_TiposSancion.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_TiposSancion.Text = "Tipos de sanción"
        '
        'menuitemTablas_Cursos
        '
        Me.menuitemTablas_Cursos.Name = "menuitemTablas_Cursos"
        Me.menuitemTablas_Cursos.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Cursos.Text = "Cursos"
        '
        'menuitemTablas_NivelesCapacitacion
        '
        Me.menuitemTablas_NivelesCapacitacion.Name = "menuitemTablas_NivelesCapacitacion"
        Me.menuitemTablas_NivelesCapacitacion.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_NivelesCapacitacion.Text = "Niveles de capacitación"
        '
        'menuitemTablas_TiposCapacitacion
        '
        Me.menuitemTablas_TiposCapacitacion.Name = "menuitemTablas_TiposCapacitacion"
        Me.menuitemTablas_TiposCapacitacion.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_TiposCapacitacion.Text = "Tipos de capacitación"
        '
        'menuitemTablas_ConceptosCalificacion
        '
        Me.menuitemTablas_ConceptosCalificacion.Name = "menuitemTablas_ConceptosCalificacion"
        Me.menuitemTablas_ConceptosCalificacion.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_ConceptosCalificacion.Text = "Conceptos de calificación"
        '
        'menuitemTablas_SeparadorUnidades
        '
        Me.menuitemTablas_SeparadorUnidades.Name = "menuitemTablas_SeparadorUnidades"
        Me.menuitemTablas_SeparadorUnidades.Size = New System.Drawing.Size(222, 6)
        '
        'menuitemTablas_TiposUnidad
        '
        Me.menuitemTablas_TiposUnidad.Name = "menuitemTablas_TiposUnidad"
        Me.menuitemTablas_TiposUnidad.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_TiposUnidad.Text = "Tipos de unidad"
        '
        'menuitemTablas_UsosUnidad
        '
        Me.menuitemTablas_UsosUnidad.Name = "menuitemTablas_UsosUnidad"
        Me.menuitemTablas_UsosUnidad.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_UsosUnidad.Text = "Usos de unidad"
        '
        'menuitemTablas_MotivosBajaUnidad
        '
        Me.menuitemTablas_MotivosBajaUnidad.Name = "menuitemTablas_MotivosBajaUnidad"
        Me.menuitemTablas_MotivosBajaUnidad.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_MotivosBajaUnidad.Text = "Motivos de baja de unidades"
        '
        'menuitemTablas_SeparadorInventario
        '
        Me.menuitemTablas_SeparadorInventario.Name = "menuitemTablas_SeparadorInventario"
        Me.menuitemTablas_SeparadorInventario.Size = New System.Drawing.Size(222, 6)
        '
        'menuitemTablas_Rubros
        '
        Me.menuitemTablas_Rubros.Name = "menuitemTablas_Rubros"
        Me.menuitemTablas_Rubros.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Rubros.Text = "Rubros de elementos"
        '
        'menuitemTablas_SubRubros
        '
        Me.menuitemTablas_SubRubros.Name = "menuitemTablas_SubRubros"
        Me.menuitemTablas_SubRubros.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_SubRubros.Text = "Sub-rubros de elementos"
        '
        'menuitemTablas_Areas
        '
        Me.menuitemTablas_Areas.Name = "menuitemTablas_Areas"
        Me.menuitemTablas_Areas.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Areas.Text = "Áreas"
        '
        'menuitemTablas_Ubicaciones
        '
        Me.menuitemTablas_Ubicaciones.Name = "menuitemTablas_Ubicaciones"
        Me.menuitemTablas_Ubicaciones.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Ubicaciones.Text = "Ubicaciones"
        '
        'menuitemTablas_SubUbicaciones
        '
        Me.menuitemTablas_SubUbicaciones.Name = "menuitemTablas_SubUbicaciones"
        Me.menuitemTablas_SubUbicaciones.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_SubUbicaciones.Text = "Sub-ubicaciones"
        '
        'menuitemTablas_SeparadorUsuarios
        '
        Me.menuitemTablas_SeparadorUsuarios.Name = "menuitemTablas_SeparadorUsuarios"
        Me.menuitemTablas_SeparadorUsuarios.Size = New System.Drawing.Size(222, 6)
        '
        'menuitemTablas_GruposUsuario
        '
        Me.menuitemTablas_GruposUsuario.Name = "menuitemTablas_GruposUsuario"
        Me.menuitemTablas_GruposUsuario.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_GruposUsuario.Text = "Grupos de usuario"
        '
        'menuitemTablas_Usuarios
        '
        Me.menuitemTablas_Usuarios.Name = "menuitemTablas_Usuarios"
        Me.menuitemTablas_Usuarios.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Usuarios.Text = "Usuarios"
        '
        'menuitemTablas_Permisos
        '
        Me.menuitemTablas_Permisos.Name = "menuitemTablas_Permisos"
        Me.menuitemTablas_Permisos.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Permisos.Text = "Permisos"
        '
        'menuitemTablas_SeparadorAlarmas
        '
        Me.menuitemTablas_SeparadorAlarmas.Name = "menuitemTablas_SeparadorAlarmas"
        Me.menuitemTablas_SeparadorAlarmas.Size = New System.Drawing.Size(222, 6)
        '
        'menuitemTablas_Alarmas
        '
        Me.menuitemTablas_Alarmas.Name = "menuitemTablas_Alarmas"
        Me.menuitemTablas_Alarmas.Size = New System.Drawing.Size(225, 22)
        Me.menuitemTablas_Alarmas.Text = "Alarmas"
        '
        'buttonPersonas
        '
        Me.buttonPersonas.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_PERSONAS_32
        Me.buttonPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPersonas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPersonas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPersonas.Name = "buttonPersonas"
        Me.buttonPersonas.Size = New System.Drawing.Size(106, 36)
        Me.buttonPersonas.Text = "Personas"
        '
        'buttonUnidades
        '
        Me.buttonUnidades.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_UNIDADES_32
        Me.buttonUnidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonUnidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonUnidades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonUnidades.Name = "buttonUnidades"
        Me.buttonUnidades.Size = New System.Drawing.Size(106, 36)
        Me.buttonUnidades.Text = "Unidades"
        '
        'buttonInventario
        '
        Me.buttonInventario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemInventario_Elementos})
        Me.buttonInventario.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_ELEMENTOS_32
        Me.buttonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonInventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonInventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonInventario.Name = "buttonInventario"
        Me.buttonInventario.Size = New System.Drawing.Size(106, 36)
        Me.buttonInventario.Text = "Inventario"
        '
        'menuitemInventario_Elementos
        '
        Me.menuitemInventario_Elementos.Name = "menuitemInventario_Elementos"
        Me.menuitemInventario_Elementos.Size = New System.Drawing.Size(129, 22)
        Me.menuitemInventario_Elementos.Text = "Elementos"
        '
        'buttonReportes
        '
        Me.buttonReportes.Image = Global.CSBomberos.DesktopApplication.My.Resources.Resources.IMAGE_REPORTES_32
        Me.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonReportes.Name = "buttonReportes"
        Me.buttonReportes.Size = New System.Drawing.Size(106, 36)
        Me.buttonReportes.Text = "Reportes"
        '
        'formMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 535)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.menustripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menustripMain
        Me.Name = "formMDIMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Title"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.menustripMain.ResumeLayout(False)
        Me.menustripMain.PerformLayout()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents labelUsuarioNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menustripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuitemArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Opciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_CerrarSesion As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_CerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_Salir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaMosaicoHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaMosaicoVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaCascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaOrganizarIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaSeparadorCerrarTodas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemVentanaCerrarTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaEncajarEnVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda_AcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonTablas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemTablas_Parentescos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentanaSeparadorListaVentanas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemDebug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonPersonas As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuitemTablas_Ubicaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonUnidades As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuitemTablas_Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonInventario As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemInventario_Elementos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_NivelesEstudio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_MotivosBajaPersonas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Cargos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_CargosJerarquias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_CausalesLicenciaPersonas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_TiposSancion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Cursos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_NivelesCapacitacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_TiposCapacitacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_ConceptosCalificacion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_TiposUnidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_UsosUnidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Areas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_SubUbicaciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Rubros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_SubRubros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_GruposUsuario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_SeparadorUnidades As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemTablas_SeparadorInventario As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemTablas_SeparadorUsuarios As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemTablas_SeparadorAlarmas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemTablas_Alarmas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_MotivosBajaUnidad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_TiposVehiculo As ToolStripMenuItem
End Class
