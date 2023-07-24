using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib.Requests.Base;

public class Request {
    public string RequestType { get; set; }

    public Request(string requestType) {
        RequestType = requestType;
    }
}

public class Request<T> : Request {
    public T? Data { get; set; }

    public Request(string requestType) : base(requestType) { }
}