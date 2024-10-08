namespace IntroducingSpecialCase.Refactored
{
    public class Customer
    {
        public virtual string Name { get; set; }

        public virtual Plan UtilityPlan { get; set; }

        public virtual bool IsUnknown { get { return false; } }

    }

    public class UnknownCustomer: Customer
    {
        public override bool IsUnknown => true;
        public override string Name
        {
            get { return "occupant"; }
            set { }
        }

        public override Plan UtilityPlan { 
            get => Plan.Basic; 
            set{ } 
        }
    }
}
