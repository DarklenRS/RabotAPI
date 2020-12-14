
using Api;
using Api.Common;
using Script;

namespace ExampleScript
{
    public class ExampleScript : RabotScript
    {
        public override int Loop()
        {
            // Script logic goes here
            if(LocalPlayer.GetHealth() > 30)
            {
                Npcs.GetNearest().DoAction(Action.ATTACK);
            }
            
            // The return value from the main loop is how long the script waits before running again. This would be handled by Rabot behind the scenes.
            return 0;
        }

        public override void OnStart()
        {
            // Before script logic: open a GUI... stuff like that
            throw new System.NotImplementedException();
        }

        public override void OnStop()
        {
            // After script stop: close GUI ... etc
            throw new System.NotImplementedException();
        }
    }
}
