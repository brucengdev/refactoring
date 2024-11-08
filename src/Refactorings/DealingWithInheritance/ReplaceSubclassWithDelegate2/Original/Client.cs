namespace ReplaceSubclassWithDelegate2.Original
{
    internal class Client
    {
        public string GetBirdInfo(BirdData data)
        {
            var bird = Bird.Create(data);

            return $"Name: {bird.Name}\n"
                + $"Plumage: {bird.Plumage}\n"
                + $"AirSpeedVelocity: {bird.AirSpeedVelocity}";
        }
    }
}
