using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerAPI.Models;
using ServerAPI.Repository;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DmBillOfLadingDetailsController : ControllerBase
    {
        private readonly IBillOfLoadingDetailRepository _context;

        public DmBillOfLadingDetailsController(IBillOfLoadingDetailRepository context)
        {
            _context = context;
        }

        // GET: api/DmBillOfLadingDetails
        [HttpGet]
        public async Task<IEnumerable<BillOfLoadingInformation>> GetDmBillOfLadingDetails()
        {
            return  _context.GetListWithDatetimeAsync();
        }

        /*// GET: api/DmBillOfLadingDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DmBillOfLadingDetail>> GetDmBillOfLadingDetail(Guid id)
        {
            var dmBillOfLadingDetail = await _context.DmBillOfLadingDetails.FindAsync(id);

            if (dmBillOfLadingDetail == null)
            {
                return NotFound();
            }

            return dmBillOfLadingDetail;
        }

        // PUT: api/DmBillOfLadingDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDmBillOfLadingDetail(Guid id, DmBillOfLadingDetail dmBillOfLadingDetail)
        {
            if (id != dmBillOfLadingDetail.BlrowId)
            {
                return BadRequest();
            }

            _context.Entry(dmBillOfLadingDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DmBillOfLadingDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DmBillOfLadingDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DmBillOfLadingDetail>> PostDmBillOfLadingDetail(DmBillOfLadingDetail dmBillOfLadingDetail)
        {
            _context.DmBillOfLadingDetails.Add(dmBillOfLadingDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DmBillOfLadingDetailExists(dmBillOfLadingDetail.BlrowId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDmBillOfLadingDetail", new { id = dmBillOfLadingDetail.BlrowId }, dmBillOfLadingDetail);
        }

        // DELETE: api/DmBillOfLadingDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDmBillOfLadingDetail(Guid id)
        {
            var dmBillOfLadingDetail = await _context.DmBillOfLadingDetails.FindAsync(id);
            if (dmBillOfLadingDetail == null)
            {
                return NotFound();
            }

            _context.DmBillOfLadingDetails.Remove(dmBillOfLadingDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DmBillOfLadingDetailExists(Guid id)
        {
            return _context.DmBillOfLadingDetails.Any(e => e.BlrowId == id);
        }*/
    }
}
