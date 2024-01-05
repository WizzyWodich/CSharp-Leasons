namespace Leasons_22
    // Создам интерфейс Jump
{
    interface IJump
    {
        // Допустим аксессор это высота на которою робот будет подпрыгивать и метод пражка.
        float y { get; set; } 

        void Jump();
        // Теперь идем в Robot.cs
    }
}