namespace Practice17_3_1 {
    public interface ITextFileService {
        void Initialize(string vFname);
        void Execute(string vLine);
        void Terminate();
    }
}
