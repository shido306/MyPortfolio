using Portfolio.Models;

namespace Portfolio.Services;

public class FooterServices
{
	public List<FooterCategory> GetFooters()
	{
		return new List<FooterCategory>
		{
			new FooterCategory
			{
				Title = "Internal Links",
				Links = new List<Link>
				{
					new Link { LinkText = "Home", LinkUrl = "" },
					new Link { LinkText = "My work", LinkUrl = "Work" },
					new Link { LinkText = "What I Use", LinkUrl = "Techs" }
				}
			},
			new FooterCategory
			{
				Title = "Links",
				Links = new List<Link>
				{
					new Link { LinkText = "GitHub", LinkUrl = "https://github.com/shido306/", Target = "_blank" },
				}
			},
			new FooterCategory
			{
				Title = "Contact me",
				Links = new List<Link>
				{
					new Link { LinkText = "Gmail", LinkUrl = "mailto:shido2910@gmail.com", Target = "_blank" },
					new Link { LinkText = "Discord", LinkUrl = "https://discord.com/users/shido306", Target = "_blank" },
					new Link { LinkText = "Twitter / X", LinkUrl = "https://x.com/shido306", Target = "_blank" },
				}
			}
		};
	}
}
