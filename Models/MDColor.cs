﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeColors_UWP
{
    public class MDColor
    {
        public string Name { get; set; }
        public string Hex { get; set; }

        public MDColor(string name, string hex) { this.Name = name; this.Hex = hex; }
    }

    public static class AllMDColors
    {
        public static List<MDColor> RedList = new List<MDColor> {new MDColor("500", "#F44336"),
                                                                 new MDColor("500", "#F44336"),
                                                                 new MDColor("50", "#FFEBEE"),
                                                                 new MDColor("100", "#FFCDD2"),
                                                                 new MDColor("200", "#EF9A9A"),
                                                                 new MDColor("300", "#E57373"),
                                                                 new MDColor("400", "#EF5350"),
                                                                 new MDColor("500", "#F44336"),
                                                                 new MDColor("600", "#E53935"),
                                                                 new MDColor("700", "#D32F2F"),
                                                                 new MDColor("800", "#C62828"),
                                                                 new MDColor("900", "#B71C1C"),
                                                                 new MDColor("A100", "#FF8A80"),
                                                                 new MDColor("A200", "#FF5252"),
                                                                 new MDColor("A400", "#FF1744"),
                                                                 new MDColor("A700", "#D50000") };
        public static List<MDColor> PinkList = new List<MDColor> {new MDColor("500", "#E91E63"),
                                                                  new MDColor("50", "#FCE4EC"),
                                                                  new MDColor("100", "#F8BBD0"),
                                                                  new MDColor("200", "#F48FB1"),
                                                                  new MDColor("300", "#F06292"),
                                                                  new MDColor("400", "#EC407A"),
                                                                  new MDColor("500", "#E91E63"),
                                                                  new MDColor("600", "#D81B60"),
                                                                  new MDColor("700", "#C2185B"),
                                                                  new MDColor("800", "#AD1457"),
                                                                  new MDColor("900", "#880E4F"),
                                                                  new MDColor("A100", "#FF80AB"),
                                                                  new MDColor("A200", "#FF4081"),
                                                                  new MDColor("A400", "#F50057"),
                                                                  new MDColor("A700", "#C51162") };
        public static List<MDColor> PurpleList = new List<MDColor> { new MDColor("500", "#9C27B0"),
                                                                     new MDColor("50", "#F3E5F5"),
                                                                     new MDColor("100", "#E1BEE7"),
                                                                     new MDColor("200", "#CE93D8"),
                                                                     new MDColor("300", "#BA68C8"),
                                                                     new MDColor("400", "#AB47BC"),
                                                                     new MDColor("500", "#9C27B0"),
                                                                     new MDColor("600", "#8E24AA"),
                                                                     new MDColor("700", "#7B1FA2"),
                                                                     new MDColor("800", "#6A1B9A"),
                                                                     new MDColor("900", "#4A148C"),
                                                                     new MDColor("A100", "#EA80FC"),
                                                                     new MDColor("A200", "#E040FB"),
                                                                     new MDColor("A400", "#D500F9"),
                                                                     new MDColor("A700", "#AA00FF") };
        public static List<MDColor> DeepPurpleList = new List<MDColor> {new MDColor("500", "#673AB7"),
                                                                        new MDColor("50", "#EDE7F6"),
                                                                        new MDColor("100", "#D1C4E9"),
                                                                        new MDColor("200", "#B39DDB"),
                                                                        new MDColor("300", "#9575CD"),
                                                                        new MDColor("400", "#7E57C2"),
                                                                        new MDColor("500", "#673AB7"),
                                                                        new MDColor("600", "#5E35B1"),
                                                                        new MDColor("700", "#512DA8"),
                                                                        new MDColor("800", "#4527A0"),
                                                                        new MDColor("900", "#311B92"),
                                                                        new MDColor("A100", "#B388FF"),
                                                                        new MDColor("A200", "#7C4DFF"),
                                                                        new MDColor("A400", "#651FFF"),
                                                                        new MDColor("A700", "#6200EA") };
        public static List<MDColor> IndigoList = new List<MDColor> { new MDColor("500", "#3F51B5"),
                                                                     new MDColor("50", "#E8EAF6"),
                                                                     new MDColor("100", "#C5CAE9"),
                                                                     new MDColor("200", "#9FA8DA"),
                                                                     new MDColor("300", "#7986CB"),
                                                                     new MDColor("400", "#5C6BC0"),
                                                                     new MDColor("500", "#3F51B5"),
                                                                     new MDColor("600", "#3949AB"),
                                                                     new MDColor("700", "#303F9F"),
                                                                     new MDColor("800", "#283593"),
                                                                     new MDColor("900", "#1A237E"),
                                                                     new MDColor("A100", "#8C9EFF"),
                                                                     new MDColor("A200", "#536DFE"),
                                                                     new MDColor("A400", "#3D5AFE"),
                                                                     new MDColor("A700", "#304FFE")};
        public static List<MDColor> BlueList = new List<MDColor> { new MDColor("500", "#2196F3"),
                                                                   new MDColor("50", "#E3F2FD"),
                                                                   new MDColor("100", "#BBDEFB"),
                                                                   new MDColor("200", "#90CAF9"),
                                                                   new MDColor("300", "#64B5F6"),
                                                                   new MDColor("400", "#42A5F5"),
                                                                   new MDColor("500", "#2196F3"),
                                                                   new MDColor("600", "#1E88E5"),
                                                                   new MDColor("700", "#1976D2"),
                                                                   new MDColor("800", "#1565C0"),
                                                                   new MDColor("900", "#0D47A1"),
                                                                   new MDColor("A100", "#82B1FF"),
                                                                   new MDColor("A200", "#448AFF"),
                                                                   new MDColor("A400", "#2979FF"),
                                                                   new MDColor("A700", "#2962FF") };
        public static List<MDColor> LightBlueList = new List<MDColor> {new MDColor("500", "#03A9F4"),
new MDColor("50", "#E1F5FE"),
new MDColor("100", "#B3E5FC"),
new MDColor("200", "#81D4FA"),
new MDColor("300", "#4FC3F7"),
new MDColor("400", "#29B6F6"),
new MDColor("500", "#03A9F4"),
new MDColor("600", "#039BE5"),
new MDColor("700", "#0288D1"),
new MDColor("800", "#0277BD"),
new MDColor("900", "#01579B"),
new MDColor("A100", "#80D8FF"),
new MDColor("A200", "#40C4FF"),
new MDColor("A400", "#00B0FF"),
new MDColor("A700", "#0091EA") };
        public static List<MDColor> CyanList = new List<MDColor> {new MDColor("500", "#00BCD4"),
new MDColor("50", "#E0F7FA"),
new MDColor("100", "#B2EBF2"),
new MDColor("200", "#80DEEA"),
new MDColor("300", "#4DD0E1"),
new MDColor("400", "#26C6DA"),
new MDColor("500", "#00BCD4"),
new MDColor("600", "#00ACC1"),
new MDColor("700", "#0097A7"),
new MDColor("800", "#00838F"),
new MDColor("900", "#006064"),
new MDColor("A100", "#84FFFF"),
new MDColor("A200", "#18FFFF"),
new MDColor("A400", "#00E5FF"),
new MDColor("A700", "#00B8D4") };
        public static List<MDColor> TealList = new List<MDColor> { new MDColor("500", "#009688"),
new MDColor("50", "#E0F2F1"),
new MDColor("100", "#B2DFDB"),
new MDColor("200", "#80CBC4"),
new MDColor("300", "#4DB6AC"),
new MDColor("400", "#26A69A"),
new MDColor("500", "#009688"),
new MDColor("600", "#00897B"),
new MDColor("700", "#00796B"),
new MDColor("800", "#00695C"),
new MDColor("900", "#004D40"),
new MDColor("A100", "#A7FFEB"),
new MDColor("A200", "#64FFDA"),
new MDColor("A400", "#1DE9B6"),
new MDColor("A700", "#00BFA5") };
        public static List<MDColor> GreenList = new List<MDColor> { new MDColor("500", "#4CAF50"),
new MDColor("50", "#E8F5E9"),
new MDColor("100", "#C8E6C9"),
new MDColor("200", "#A5D6A7"),
new MDColor("300", "#81C784"),
new MDColor("400", "#66BB6A"),
new MDColor("500", "#4CAF50"),
new MDColor("600", "#43A047"),
new MDColor("700", "#388E3C"),
new MDColor("800", "#2E7D32"),
new MDColor("900", "#1B5E20"),
new MDColor("A100", "#B9F6CA"),
new MDColor("A200", "#69F0AE"),
new MDColor("A400", "#00E676"),
new MDColor("A700", "#00C853") };
        public static List<MDColor> LightGreenList = new List<MDColor> {new MDColor("500", "#8BC34A"),
new MDColor("50", "#F1F8E9"),
new MDColor("100", "#DCEDC8"),
new MDColor("200", "#C5E1A5"),
new MDColor("300", "#AED581"),
new MDColor("400", "#9CCC65"),
new MDColor("500", "#8BC34A"),
new MDColor("600", "#7CB342"),
new MDColor("700", "#689F38"),
new MDColor("800", "#558B2F"),
new MDColor("900", "#33691E"),
new MDColor("A100", "#CCFF90"),
new MDColor("A200", "#B2FF59"),
new MDColor("A400", "#76FF03"),
new MDColor("A700", "#64DD17") };
        public static List<MDColor> LimeList = new List<MDColor> {new MDColor("500", "#CDDC39"),
new MDColor("50", "#F9FBE7"),
new MDColor("100", "#F0F4C3"),
new MDColor("200", "#E6EE9C"),
new MDColor("300", "#DCE775"),
new MDColor("400", "#D4E157"),
new MDColor("500", "#CDDC39"),
new MDColor("600", "#C0CA33"),
new MDColor("700", "#AFB42B"),
new MDColor("800", "#9E9D24"),
new MDColor("900", "#827717"),
new MDColor("A100", "#F4FF81"),
new MDColor("A200", "#EEFF41"),
new MDColor("A400", "#C6FF00"),
new MDColor("A700", "#AEEA00") };
        public static List<MDColor> YellowList = new List<MDColor> {new MDColor("500", "#FFEB3B"),
new MDColor("50", "#FFFDE7"),
new MDColor("100", "#FFF9C4"),
new MDColor("200", "#FFF59D"),
new MDColor("300", "#FFF176"),
new MDColor("400", "#FFEE58"),
new MDColor("500", "#FFEB3B"),
new MDColor("600", "#FDD835"),
new MDColor("700", "#FBC02D"),
new MDColor("800", "#F9A825"),
new MDColor("900", "#F57F17"),
new MDColor("A100", "#FFFF8D"),
new MDColor("A200", "#FFFF00"),
new MDColor("A400", "#FFEA00"),
new MDColor("A700", "#FFD600") };
        public static List<MDColor> AmberList = new List<MDColor> { new MDColor("500", "#FFC107"),
new MDColor("50", "#FFF8E1"),
new MDColor("100", "#FFECB3"),
new MDColor("200", "#FFE082"),
new MDColor("300", "#FFD54F"),
new MDColor("400", "#FFCA28"),
new MDColor("500", "#FFC107"),
new MDColor("600", "#FFB300"),
new MDColor("700", "#FFA000"),
new MDColor("800", "#FF8F00"),
new MDColor("900", "#FF6F00"),
new MDColor("A100", "#FFE57F"),
new MDColor("A200", "#FFD740"),
new MDColor("A400", "#FFC400"),
new MDColor("A700", "#FFAB00") };
        public static List<MDColor> OrangeList = new List<MDColor> {new MDColor("500", "#FF9800"),
new MDColor("50", "#FFF3E0"),
new MDColor("100", "#FFE0B2"),
new MDColor("200", "#FFCC80"),
new MDColor("300", "#FFB74D"),
new MDColor("400", "#FFA726"),
new MDColor("500", "#FF9800"),
new MDColor("600", "#FB8C00"),
new MDColor("700", "#F57C00"),
new MDColor("800", "#EF6C00"),
new MDColor("900", "#E65100"),
new MDColor("A100", "#FFD180"),
new MDColor("A200", "#FFAB40"),
new MDColor("A400", "#FF9100"),
new MDColor("A700", "#FF6D00") };
        public static List<MDColor> DeepOrangeList = new List<MDColor> {new MDColor("500", "#FF5722"),
new MDColor("50", "#FBE9E7"),
new MDColor("100", "#FFCCBC"),
new MDColor("200", "#FFAB91"),
new MDColor("300", "#FF8A65"),
new MDColor("400", "#FF7043"),
new MDColor("500", "#FF5722"),
new MDColor("600", "#F4511E"),
new MDColor("700", "#E64A19"),
new MDColor("800", "#D84315"),
new MDColor("900", "#BF360C"),
new MDColor("A100", "#FF9E80"),
new MDColor("A200", "#FF6E40"),
new MDColor("A400", "#FF3D00"),
new MDColor("A700", "#DD2C00") };
        public static List<MDColor> BrownList = new List<MDColor> {new MDColor("500", "#795548"),
new MDColor("50", "#EFEBE9"),
new MDColor("100", "#D7CCC8"),
new MDColor("200", "#BCAAA4"),
new MDColor("300", "#A1887F"),
new MDColor("400", "#8D6E63"),
new MDColor("500", "#795548"),
new MDColor("600", "#6D4C41"),
new MDColor("700", "#5D4037"),
new MDColor("800", "#4E342E"),
new MDColor("900", "#3E2723") };
        public static List<MDColor> GreyList = new List<MDColor> {new MDColor("500", "#9E9E9E"),
new MDColor("50", "#FAFAFA"),
new MDColor("100", "#F5F5F5"),
new MDColor("200", "#EEEEEE"),
new MDColor("300", "#E0E0E0"),
new MDColor("400", "#BDBDBD"),
new MDColor("500", "#9E9E9E"),
new MDColor("600", "#757575"),
new MDColor("700", "#616161"),
new MDColor("800", "#424242"),
new MDColor("900", "#212121") };
        public static List<MDColor> BlueGreyList = new List<MDColor> {new MDColor("500", "#607D8B"),
new MDColor("50", "#ECEFF1"),
new MDColor("100", "#CFD8DC"),
new MDColor("200", "#B0BEC5"),
new MDColor("300", "#90A4AE"),
new MDColor("400", "#78909C"),
new MDColor("500", "#607D8B"),
new MDColor("600", "#546E7A"),
new MDColor("700", "#455A64"),
new MDColor("800", "#37474F"),
new MDColor("900", "#263238") };

        public static List<List<MDColor>> AllAllColors = new List<List<MDColor>> { RedList, PinkList, PurpleList, DeepPurpleList, IndigoList, BlueList, LightBlueList, CyanList, TealList, GreenList, LightGreenList, LimeList, YellowList, AmberList, OrangeList, DeepOrangeList, BrownList, GreyList, BlueGreyList };
    }
}