namespace BerekeningRondNamespace
{

    public class BerekeningRond{
        private double _diameter;

        private  double _snelheid;

        public double Diameter{
            get{return _diameter;}
            set{_diameter = value;}
        }

        public double Snelheid{
            get{return _snelheid;}
            set{_snelheid = value;}
        }
        public double OppervlakteRond(){
            double OppRond = (Math.Pow(_diameter,2))*Math.PI;
            return OppRond;
        }

        public double DebietsBerekeningRond(){
            double Debiet = Convert.ToDouble(0.25*OppervlakteRond()*_snelheid*3600);
            return Debiet;
        }
    }
}