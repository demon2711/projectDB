using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectDB
{
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            Map.Bearing = 0;
            Map.CanDragMap = true;
            Map.DragButton = MouseButtons.Left;
            Map.GrayScaleMode = true;
            Map.MarkersEnabled = true;
            Map.MaxZoom = 20;
            Map.MinZoom = 2;
            Map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            Map.NegativeMode = false;
            Map.PolygonsEnabled = true;
            Map.RoutesEnabled = true;
            Map.ShowTileGridLines = false;
            Map.Zoom = 14;
            Map.Dock = DockStyle.Fill;
            Map.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleSatelliteMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            Map.Position = new GMap.NET.PointLatLng(55.75393, 37.620795);
        }
    }
}

/*
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

    <targets>
        <target name="console" xsi:type="Console" layout="${longdate} ${level} ${message} ${exception:format=ToString}" />
        <target name="file" xsi:type="File" fileName="logfile.txt" layout="${longdate} ${level} ${message} ${exception:format=ToString}" />
    </targets>

    <rules>
        <logger name="*" minlevel="Trace" writeTo="console" />
        <logger name="*" minlevel="Info" writeTo="file" />
    </rules>
</nlog>
 
 */