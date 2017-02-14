using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVinDecoder {
    
    public class Make {
        public int id { get; set; }
        public string name { get; set; }
        public string niceName { get; set; }
    }

    public class Model {
        public string id { get; set; }
        public string name { get; set; }
        public string niceName { get; set; }
    }

    public class Transmission {
        public string id { get; set; }
        public string name { get; set; }
        public string equipmentType { get; set; }
        public string availability { get; set; }
        public string automaticType { get; set; }
        public string transmissionType { get; set; }
        public string numberOfSpeeds { get; set; }
    }

    public class Price {
        public int baseMSRP { get; set; }
        public int baseInvoice { get; set; }
        public bool estimateTmv { get; set; }
    }

    public class Option2 {
        public string id { get; set; }
        public string name { get; set; }
        public string equipmentType { get; set; }
        public string availability { get; set; }
        public string manufactureOptionName { get; set; }
        public string manufactureOptionCode { get; set; }
        public string category { get; set; }
        public Price price { get; set; }
    }

    public class Option {
        public string category { get; set; }
        public List<Option2> options { get; set; }
    }

    public class Primary {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public string hex { get; set; }
    }

    public class ColorChips {
        public Primary primary { get; set; }
    }

    public class Option3 {
        public string id { get; set; }
        public string name { get; set; }
        public string equipmentType { get; set; }
        public string availability { get; set; }
        public string manufactureOptionName { get; set; }
        public string manufactureOptionCode { get; set; }
        public string category { get; set; }
        public ColorChips colorChips { get; set; }
        public List<object> fabricTypes { get; set; }
    }

    public class Color {
        public string category { get; set; }
        public List<Option3> options { get; set; }
    }

    public class Price2 {
        public int baseMSRP { get; set; }
        public int baseInvoice { get; set; }
        public int deliveryCharges { get; set; }
        public int usedTmvRetail { get; set; }
        public int usedPrivateParty { get; set; }
        public int usedTradeIn { get; set; }
        public bool estimateTmv { get; set; }
    }

    public class Categories {
        public string EPAClass { get; set; }
        public string primaryBodyType { get; set; }
        public string vehicleStyle { get; set; }
        public string vehicleType { get; set; }
    }

    public class Submodel {
        public string body { get; set; }
        public string modelName { get; set; }
        public string niceName { get; set; }
    }

    public class Style {
        public int id { get; set; }
        public string name { get; set; }
        public Submodel submodel { get; set; }
        public string trim { get; set; }
    }

    public class Year {
        public int id { get; set; }
        public int year { get; set; }
        public List<Style> styles { get; set; }
        public List<string> states { get; set; }
    }

    public class Equipment {
        public string id { get; set; }
        public string name { get; set; }
        public string equipmentType { get; set; }
        public string availability { get; set; }
        public double compressionRatio { get; set; }
        public int cylinder { get; set; }
        public double size { get; set; }
        public int displacement { get; set; }
        public string configuration { get; set; }
        public string fuelType { get; set; }
        public int horsepower { get; set; }
        public int torque { get; set; }
        public int totalValves { get; set; }
        public string manufacturerEngineCode { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string compressorType { get; set; }
        public string automaticType { get; set; }
        public string transmissionType { get; set; }
        public string numberOfSpeeds { get; set; }
    }

    public class MPG {
        public string highway { get; set; }
        public string city { get; set; }
    }

    public class RootObjectCar {
        public Make make { get; set; }
        public Model model { get; set; }
        public Transmission transmission { get; set; }
        public string drivenWheels { get; set; }
        public string numOfDoors { get; set; }
        public List<Option> options { get; set; }
        public List<Color> colors { get; set; }
        public string manufacturerCode { get; set; }
        public Price2 price { get; set; }
        public Categories categories { get; set; }
        public string vin { get; set; }
        public string squishVin { get; set; }
        public List<Year> years { get; set; }
        public string matchingType { get; set; }
        public List<Equipment> equipment { get; set; }
        public MPG MPG { get; set; }
    }
    
}
