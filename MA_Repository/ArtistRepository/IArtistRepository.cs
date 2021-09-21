namespace MA_Repository
{
    using MA_Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IArtistRepository<T> where T: Artist, IRepository<T> 
    {

    }
}
