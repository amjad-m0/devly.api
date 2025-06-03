using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Devly.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        public record Testimonial(string Name, string Company, string Quote, string Avatar);

        [HttpGet]
        public IActionResult GetTestimonials()
        {
            var testimonials = new[]
            {
                new Testimonial(
                    "Sarah Ali",
                    "TechEdge Solutions",
                    "Devly delivered beyond expectations. The team understood our needs and created a platform that boosted engagement by 3x.",
                    "https://randomuser.me/api/portraits/women/68.jpg"
                ),
                new Testimonial(
                    "Ahmed Rami",
                    "NextMark Agency",
                    "Professional, responsive, and technically outstanding. Our marketing site went live in record time.",
                    "https://randomuser.me/api/portraits/men/41.jpg"
                ),
                new Testimonial(
                    "Nour Hamdy",
                    "Alt Digital",
                    "Loved working with Devly! Their design sense and frontend expertise made our product shine.",
                    "https://randomuser.me/api/portraits/women/23.jpg"
                )
            };

            return Ok(testimonials);
        }
    }
}
