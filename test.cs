internal sealed class Structure {

    private HashSet<int> Elements { get; set; }

    public bool AddElement(int element) {
        return Elements.Add(element);
    }

    public bool RemoveElement(int element) {
        if (!Elements.Contains(element))
            return false;

        Elements.Add(element);
    }

    public int GetRandomElement() {
        // throw exception here instead as the -1 may be mistaken for an element
        if (Elements.Length < 1) return -1; 

        var rand = new Random();
        return rand.Next(0, Elements.Length - 1);
    }


}