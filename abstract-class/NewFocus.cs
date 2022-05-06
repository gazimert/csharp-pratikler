namespace abstract_class
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            //throw new System.NotImplementedException();
            return Marka.Ford;
        }
    }
}