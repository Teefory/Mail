using DataModels;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Mail.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : Controller
    {
        private readonly MailDB _connection;
        public ClientsController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<Client>> ListPeople()
        {
            return await _connection.Clients.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Client> GetClient(int id)
        {
            return await _connection.Clients.SingleOrDefaultAsync(Client => Client.ClientId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteClient(int id)
        {
            return await _connection.Clients.Where(Client => Client.ClientId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateClient(Client clients)
        {
            return await _connection.Clients.DataContext.UpdateAsync(clients);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateClientName(int id, string newName)
        {
            return await _connection.Clients.Where(Client => Client.ClientId == id)
                                            .Set(Client => Client.Name, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertPerson(Client clients)
        {
            return await _connection.Clients.DataContext.InsertAsync(clients);
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly MailDB _connection;
        public EmployeeController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<Employee>> ListPeople()
        {
            return await _connection.Employees.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await _connection.Employees.SingleOrDefaultAsync(Employee => Employee.EmployeeId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _connection.Employees.Where(Employee => Employee.EmployeeId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            return await _connection.Employees.DataContext.UpdateAsync(employee);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateEmployeeName(int id, string newName)
        {
            return await _connection.Employees.Where(Employee => Employee.EmployeeId == id)
                                            .Set(Employee => Employee.Name, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertEmployee(Employee employees)
        {
            return await _connection.Employees.DataContext.InsertAsync(employees);
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class ParcelController : Controller
    {
        private readonly MailDB _connection;
        public ParcelController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<Parcel>> ListParcel()
        {
            return await _connection.Parcels.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Parcel> GetParcel(int id)
        {
            return await _connection.Parcels.SingleOrDefaultAsync(Parcel => Parcel.ParcelId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteParcel(int id)
        {
            return await _connection.Parcels.Where(Parcel => Parcel.ParcelId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateParcel(Parcel parcel)
        {
            return await _connection.Parcels.DataContext.UpdateAsync(parcel);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateParcelName(int id, int newName)
        {
            return await _connection.Parcels.Where(Parcel => Parcel.ParcelId == id)
                                            .Set(Parcel => Parcel.Sender, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertParcel(Parcel parcels)
        {
            return await _connection.Parcels.DataContext.InsertAsync(parcels);
        }
    }



    [ApiController]
    [Route("[controller]")]
    public class PostalDepartmentController : Controller
    {
        private readonly MailDB _connection;
        public PostalDepartmentController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<PostalDepartment>> ListPostalDepartment()
        {
            return await _connection.PostalDepartments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<PostalDepartment> GetPostalDepartment(int id)
        {
            return await _connection.PostalDepartments.SingleOrDefaultAsync(PostalDepartment => PostalDepartment.PostalDepartmentId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeletePostalDepartment(int id)
        {
            return await _connection.PostalDepartments.Where(PostalDepartment => PostalDepartment.PostalDepartmentId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdatePostalDepartment(PostalDepartment postalDepartment)
        {
            return await _connection.PostalDepartments.DataContext.UpdateAsync(postalDepartment);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdatePostalDepartmentName(int id, string newName)
        {
            return await _connection.PostalDepartments.Where(PostalDepartment => PostalDepartment.PostalDepartmentId == id)
                                            .Set(PostalDepartment => PostalDepartment.Number, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertPostalDepartment(PostalDepartment PostalDepartments)
        {
            return await _connection.PostalDepartments.DataContext.InsertAsync(PostalDepartments);
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class StatusController : Controller
    {
        private readonly MailDB _connection;
        public StatusController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<Status>> ListStatus()
        {
            return await _connection.Status.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Status> GetStatus(int id)
        {
            return await _connection.Status.SingleOrDefaultAsync(Status => Status.StatusId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteStatus(int id)
        {
            return await _connection.Status.Where(Status => Status.StatusId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateStatus(Status status)
        {
            return await _connection.Status.DataContext.UpdateAsync(status);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateStatus(int id, int newName)
        {
            return await _connection.Status.Where(Status => Status.StatusId == id)
                                            .Set(Status => Status.ParcelId, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertStatus(Status Statuss)
        {
            return await _connection.Status.DataContext.InsertAsync(Statuss);
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class TypeController : Controller
    {
        private readonly MailDB _connection;
        public TypeController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<Types>> ListType()
        {
            return await _connection.Typeses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Types> GetType(int id)
        {
            return await _connection.Typeses.SingleOrDefaultAsync(Type => Type.TypeId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteType(int id)
        {
            return await _connection.Typeses.Where(Type => Type.TypeId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateType(Type type)
        {
            return await _connection.Typeses.DataContext.UpdateAsync(type);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateType(int id, int newName)
        {
            return await _connection.Typeses.Where(Type => Type.TypeId == id)
                                            .Set(Type => Type.TypeId, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertType(Type Types)
        {
            return await _connection.Typeses.DataContext.InsertAsync(Types);
        }
    }


    [ApiController]
    [Route("[controller]")]
    public class StatusReferenceController : Controller
    {
        private readonly MailDB _connection;
        public StatusReferenceController(MailDB connection)
        {
            _connection = connection;
        }

        [HttpGet]
        public async Task<List<StatusReference>> ListStatusReference()
        {
            return await _connection.StatusReferences.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<StatusReference> GetStatusReference(int id)
        {
            return await _connection.StatusReferences.SingleOrDefaultAsync(StatusReference => StatusReference.StatusReferenceId == id);
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteStatusReference(int id)
        {
            return await _connection.StatusReferences.Where(StatusReference => StatusReference.StatusReferenceId == id).DeleteAsync();
        }


        [HttpPatch]
        public async Task<int> UpdateStatusReference(StatusReference StatusReference)
        {
            return await _connection.StatusReferences.DataContext.UpdateAsync(StatusReference);

        }

        [HttpPatch("{id}/new-name")]
        public async Task<int> UpdateStatusReference(int id, int newName)
        {
            return await _connection.StatusReferences.Where(StatusReference => StatusReference.StatusReferenceId == id)
                                            .Set(StatusReference => StatusReference.StatusReferenceId, newName)
                                            .UpdateAsync();
        }

        [HttpPut]
        public async Task<int> InsertStatusReference(StatusReference StatusReferences)
        {
            return await _connection.StatusReferences.DataContext.InsertAsync(StatusReferences);
        }
    }


}
