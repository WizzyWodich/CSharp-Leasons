namespace Leasons_22
    // ������ ��������� Jump
{
    interface IJump
    {
        // �������� �������� ��� ������ �� ������� ����� ����� ������������ � ����� ������.
        float y { get; set; } 

        void Jump();
        // ������ ���� � Robot.cs
    }
}