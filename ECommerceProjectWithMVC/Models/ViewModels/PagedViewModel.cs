using ECommerceProjectWithMVC.Models.DataContexts;
using ECommerceProjectWithMVC.Models.Entities;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerceProjectWithMVC.Models.ViewModels
{
    public class PagedViewModel<T>
        where T : class
    {
        const int pageIndexLimit = 10; 
        int pageIndex;
        int pageSize;

        public int PageIndex {
            get
            {
                return pageIndex;
            }
            set
            {
                this.pageIndex = value < 1 ? 1 : value ;
            }
        }
        public int PageSize
        {
            get
            {
                return pageSize;
            }
            set
            {
                this.pageSize = value < 12 ? 12 : (value>100?100:value);
            }
        }
        public int TotalCount { get; set; }
        public List<T> Items { get; set; }
        public int MaxPageCount { 
            get {

                return (int)Math.Ceiling(TotalCount * 1.0 / PageSize);
            } 
        }


        public PagedViewModel(List<T> list,int pageIndex,int pageSize)
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.TotalCount = list.Count();


            if (this.PageIndex >MaxPageCount)
            {
                this.PageIndex = MaxPageCount;
            }

            


            this.Items = list.Skip((this.PageIndex - 1) * this.PageSize).Take(this.PageSize).ToList();

        }

        public HtmlString GetPagenation(IUrlHelper url,string action="index",string area="")
        {
            if(MaxPageCount < 2)
            {
                return HtmlString.Empty;
            }
            else {
                StringBuilder sb = new StringBuilder();
                sb.Append("<nav aria-label='Page navigation example'>");
                sb.Append("<ul class='pagination'>");





                if (this.PageIndex == 1)
                {
                    sb.Append("<li disabled class='page-item'><a class='page-link' href='#'>Previous</a></li>");
                }
                else
                {
                    string link = url.Action(action, values: new
                    {
                        pageIndex = this.pageIndex -1,
                        pageSize = this.PageSize,
                        area = area
                    });
                    sb.Append(@$"<li class='page-item'><a class='page-link' href='{link}'>Previous</a></li>");
                }



                int offset = (int)Math.Ceiling(pageIndexLimit / 2.0);
                int start = this.PageIndex;
                int end = start + pageIndexLimit - 1;

                if (this.PageIndex - offset < 1)
                {
                    start = 1;
                }
                else
                {
                    start = this.PageIndex - offset;
                }


                end = start + pageIndexLimit - 1;


                if (end > MaxPageCount)
                {
                    end = MaxPageCount;
                }






                for (int i = start; i <= end; i++)
                {
                    string link = url.Action(action, values: new
                    {
                        pageIndex = i,
                        pageSize = this.PageSize,
                        area = area
                    });
                    if(i == this.PageIndex)
                    {
                        sb.Append(@$"<li class='page-item'><a class='page-link'>{i}</li>");
                    }
                    else
                    {
                        sb.Append(@$"<li class='page-item'><a class='page-link' href='{link}'>{i}</a></li>");
                    }
                }






                if (this.pageIndex == this.MaxPageCount)
                {
                    sb.Append("<li disabled class='page-item'><a class='page-link' href='#'>Next</a></li>");
                }
                else
                {
                    string link = url.Action(action, values: new
                    {
                        pageIndex = this.pageIndex + 1,
                        pageSize = this.PageSize,
                        area = area
                    });
                    sb.Append(@$"<li class='page-item'><a class='page-link' href='{link}'>Next</a></li>");
                }

                sb.Append("</ul>");
                sb.Append("</nav>");
                return new HtmlString(sb.ToString());
                /*

                     <nav aria-label='Page navigation example'>
                      <ul class='pagination'>
                        <li class='page-item'><a class='page-link' href='#'>Previous</a></li>
                        <li class='page-item'><a class='page-link' href='#'>1</a></li>
                        <li class='page-item'><a class='page-link' href='#'>2</a></li>
                        <li class='page-item'><a class='page-link' href='#'>3</a></li>
                        <li class='page-item'><a class='page-link' href='#'>Next</a></li>
                      </ul>
                    </nav>
                 */


            }


        }
    }
}
