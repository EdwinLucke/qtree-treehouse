using System;
using System.Collections.Generic;
using System.Text;

namespace qtree.standard.lib
{
    /// <summary>
    /// Simple chimp class in order to test the chimp chasing game between chimps.
    /// The winning chimp is the one that has more energy then his target.
    /// If the target has an energy level of 0 and the chasing chimps lvl is > 0 
    /// the chaser wins this chimp game of tag.
    /// Reason for chimp class is to get multiple testrunners enabled:
    /// mstest, xunit
    /// </summary>
    public class Chimp
    {
        public string Name { get; set; } = Guid.NewGuid().ToString();
        private bool Dodging { get { return HasEnergy(); } }
        private bool caught = false;
        private int Energy { get; set; } = 5;
        private Chimp PlayMate { get; set; }

        public Chimp(int energyLevel)
        {
            Energy = energyLevel;
        }


        public bool IsDodging()
        {
            return Dodging;
        }

        public bool IsTagged()
        {
            caught = !HasEnergy();
            Console.WriteLine($"[{Energy}]{Name} {(caught ? "taggedBy" : "escaped")}:{PlayMate?.Name??string.Empty}");
            return caught;
        }

        private void Move()
        {
            Energy--;
            Console.WriteLine($"[{Energy}]{Name} - moved and used energy");
        }

        public void PlayWith(Chimp chimp)
        {
            PlayMate = chimp;
            PlayMate.PlayMate = this;
            while (HasEnergy())
            {
                
                //both chimps try to move when the playmate is nit yet tagged
                if (!PlayMate.IsTagged() && PlayMate.HasEnergy() && HasEnergy())
                {
                    Move();
                    PlayMate.Move();
                }
                else { break; }
            }
        }

        public void Recharge()
        {
            Energy += 3;
        }

        public bool HasEnergy()
        {
            return Energy > 0;
        }
    }
}
