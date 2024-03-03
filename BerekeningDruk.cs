namespace BerekeningDrukNamespace{
    public class BerekeningDruk{
        private double _oudDebiet;

        private double _oudDruk;

        private double _nieuwDruk;

        public double oudDebiet{
            get{return _oudDebiet;}
            set{_oudDebiet = value;}
        }

        public double oudDruk{
            get{return _oudDruk;}
            set{_oudDruk = value;}
        }

        public double nieuwDruk{
            get{return _nieuwDruk;}
            set{_nieuwDruk = value;}
        }

        public double DebietsBerekening(){
            double nieuwDebiet = _oudDebiet*Math.Sqrt((_nieuwDruk/_oudDruk));
            return nieuwDebiet;
        } 
    }



}