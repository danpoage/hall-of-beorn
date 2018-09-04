using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.LotR
{
    public enum RelationshipType
    {
        Father_Son,
        Father_Daughter,
        Mother_Son,
        Mother_Daughter,
        Grandfather_Grandson,
        Grandfather_Granddaughter,
        Grandmother_Grandson,
        Grandmother_Granddaughter,
        Uncle_Nephew,
        Uncle_Niece,
        Aunt_Nephew,
        Aunt_Niece,
        Brother_Brother,
        Brother_Sister,
        Sister_Sister,
        Lord_Vassal,
        Leader_Group,
        Member_Group,
        Friend,
        Weapon,
        Mount,
        Possession
    }

    public class CharacterRelationship
    {
        public CharacterRelationship(string subjectName, RelationshipType type, string objectName)
        {
            this.SubjectName = subjectName;
            this.SubjectSlug = subjectName.Slugify();
            this.Type = type;
            this.ObjectName = objectName;
            this.ObjectSlug = objectName.Slugify();
        }

        private string getSubjectRole()
        {
            return Type.ToString().Split('_').First();
        }

        private string getObjectRole()
        {
            return Type.ToString().Split('_').Last();
        }

        public string SubjectName { get; protected set; }
        public string SubjectSlug { get; protected set; }
        public RelationshipType Type { get; protected set; }
        public string ObjectName { get; protected set; }
        public string ObjectSlug { get; protected set; }

        public string SubjectLabel()
        {
            switch (Type)
            {
                case RelationshipType.Weapon:
                case RelationshipType.Mount:
                case RelationshipType.Possession:
                    return SubjectName;
                default:
                    return string.Format("{0} ({1})", ObjectName, getObjectRole());
            }
        }

        public string SubjectDescription()
        {
            switch (Type)
            {
                case RelationshipType.Weapon:
                    return string.Format("Wields {0}", SubjectName);
                case RelationshipType.Mount:
                    return string.Format("Rides {0}", SubjectName);
                case RelationshipType.Possession:
                    return string.Format("Possesses {0}", SubjectName);
                default:
                    return string.Format("{0} of {1}", getSubjectRole(), ObjectName);
            }
        }

        public string ObjectLabel()
        {
            switch (Type)
            {
                case RelationshipType.Weapon:
                case RelationshipType.Mount:
                case RelationshipType.Possession:
                    return SubjectName;
                default:
                    return string.Format("{0} ({1})", SubjectName, getSubjectRole());
            }
        }

        public string ObjectDescription()
        {
            switch (Type)
            {
                case RelationshipType.Leader_Group:
                    return string.Format("Lead by {0}", SubjectName);
                case RelationshipType.Member_Group:
                    return string.Format("Includes {0}", SubjectName);
                case RelationshipType.Weapon:
                    return string.Format("Wielded by {0}", SubjectName);
                case RelationshipType.Mount:
                    return string.Format("Ridden by {0}", SubjectName);
                case RelationshipType.Possession:
                    return string.Format("Possessed by {0}", SubjectName);
                default:
                    return string.Format("{0} of {1}", getObjectRole(), SubjectName);
            }
        }
    }
}