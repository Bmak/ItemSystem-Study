namespace ItemSystem
{
    public interface IISEquipable
    {
        ISEquipmentSlot Equipment { get; }
        bool Equip();
    }
}


