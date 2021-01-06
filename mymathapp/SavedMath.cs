using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace mymathapp
{
    public class SavedMath
    {
        // New list 
        private List<Post> posts = new List<Post>();

        public SavedMath()
        {
            if (File.Exists(@"savedmath.data") == true)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(@"savedmath.data", FileMode.Open, FileAccess.Read);

                while (stream.Position < stream.Length)
                {
                    Post objnew = (Post)formatter.Deserialize(stream);
                    posts.Add(objnew);
                }
                stream.Close();
            }
        }

        // Adding new post to savedmath
        public Post addMath(Post post)
        {
            posts.Add(post);
            marshaling();
            return post;
        }

        // Deleting a post in savedmath
        public int delMath(int index)
        {
            posts.RemoveAt(index);
            marshaling();
            return index;
        }

        // Get posts in savedmath
        public List<Post> getMaths()
        {
            return posts;
        }

        // Using marshaling to serialize data and writing to file
        private void marshaling()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"savedmath.data", FileMode.Create, FileAccess.Write);

            foreach (Post obj in posts)
            {
                formatter.Serialize(stream, obj);
            }
            stream.Close();
        }
    }

    [Serializable]

    // Setter and getter for content in SavedMath
    public class Post
    {
        public string Saved { set; get; }
    }
}
