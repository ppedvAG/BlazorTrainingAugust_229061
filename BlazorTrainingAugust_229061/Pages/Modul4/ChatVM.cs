namespace BlazorTrainingAugust_229061.Pages.Modul4
{
    public class ChatVM
    {

        public Action OnAdd;
        public List<NachrichtModel> ChatListe { get; set;}=new List<NachrichtModel>();
        public void Add(string msg)
        {
            ChatListe.Add(new NachrichtModel() { Text = msg });
            OnAdd?.Invoke();

        }
    }
}
