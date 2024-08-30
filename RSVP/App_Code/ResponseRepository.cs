using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;


public class ResponseRepository
{
    private static ResponseRepository repository = new ResponseRepository();
    private List<GuestResponse> responses = new List<GuestResponse>();
    public static ResponseRepository GetRepository() { return repository; }
    public IEnumerable<GuestResponse> GetAllResponses () { return responses; }
    public void AddResponses(GuestResponse response)
    {
        responses.Add(response);
    }
}