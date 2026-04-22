using Portfolio.Models;

namespace Portfolio.Services;

public class ProjectServices : IProjectServices
{
    public List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                ProjectName = "Portfolio Site",
                Started = DateTime.Parse("2026-04-14"),
                Ended = DateTime.Parse("2026-04-21"),
				Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Purpose",
						Content = ".NET 10とASP.NET Core Blazor WebAssemblyの学習"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = @"GitHub Pagesでのデプロイを行い、静的サイトとして公開。
									コンポーネント設計によりUIの再利用性と保守性を向上。"
					}
				},
				Images = new List<ProImage>
				{
					new ProImage
					{
						Src = "images/projects/Portfolio.png",
						Alt = " main page ",
						Width = 1343,
						Height = 606
					}
				},
				Technologies = new List<Technology>
				{
					new Technology{ Name = ".NET Core", Icon = "images/icon/Dotnet_Icon.svg"},
					new Technology{ Name = "C#", Icon = "images/icon/CSharp_Icon.svg"},
					new Technology{ Name = "Blazor .NET 10", Icon = "images/icon/Blazor_Icon.svg"},
					new Technology{ Name = "Github", Icon = "images/icon/Github_Icon.svg"},
					new Technology{ Name = "Web Assembly", Icon = "images/icon/WebAssembly_Icon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
				},
				Links = new List<Link>
				{
				},
				GithubLink = "https://github.com/shido306/MyPortfolio",
			},
            new Project
            {
                ProjectName = "ExplSoda",
                Started = DateTime.Parse("2022-04"),
                Ended = DateTime.Parse("2023-02"),
				Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Content",
						Content = "対戦格闘ゲーム"
					},
					new Description
					{
						Title = "Purpose",
						Content = "卒業制作、ローカルマルチプレイゲームの開発"
					},
					new Description
					{
						Title = "My role",
						Content = "プログラム"
					},
					new Description
					{
						Title = "Team size",
						Content = "3人"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = @"プログラマ以外のメンバーでもパラメータ調整ができるように、ScriptableObject を用いてデータとロジックを分離しました。
									ローカルマルチプレイおよび複数種類のコントローラーに対応するため、Unity Input System を導入し、入力デバイスに依存しない柔軟な入力管理を実装しました。"
					}
				},
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "https://drive.google.com/file/d/1VcmVbA-2IyJabwG40CMeBVlewVX9UTuc/preview",
                        Alt = "PV",
                        Width = 1920,
                        Height = 1080,
                        IsVideo = true
                    }
                },
                Technologies = new List<Technology>
				{
					new Technology{ Name = "Unity", Icon = "images/icon/Unity_Icon.svg"},
					new Technology{ Name = "C#", Icon = "images/icon/CSharp_Icon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
				},
				Links = new List<Link>
				{
				},
				GithubLink = string.Empty,
			},
			new Project
			{
				ProjectName = "frhythm",
				Started = DateTime.Parse("2021-10-21"),
				Ended = DateTime.Parse("2021-11-04"),
				Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Content",
						Content = "音楽ゲーム"
					},
					new Description
					{
						Title = "Purpose",
						Content = "timelineの練習"
					},
					new Description
					{
						Title = "My role",
						Content = "プログラム、イラスト・エフェクト・UIデザイン"
					},
					new Description
					{
						Title = "Team size",
						Content = "1人"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = "オブジェクトプールを導入し、生成・破棄処理を削減することでパフォーマンス低下を防止。"
					}
				},
				Images = new List<ProImage>
				{
					new ProImage
					{
						Src = "https://drive.google.com/file/d/1KfvtG8raw7ye1wF435FUazZ5kV-9xqKe/preview",
						Alt = "PlayVideo",
						Width = 1920,
						Height = 1080,
						IsVideo = true
					}
				},
				Technologies = new List<Technology>
				{
					new Technology{ Name = "Unity", Icon = "images/icon/Unity_Icon.svg"},
					new Technology{ Name = "C#", Icon = "images/icon/CSharp_Icon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
				},
				Links = new List<Link>
				{
				},
                GithubLink = string.Empty,
			},
			new Project
			{
					ProjectName = "ラクガキ釣れます。",
					Started = DateTime.Parse("2022-06-16"),
					Ended = DateTime.Parse("2022-08-31"),
					Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Content",
						Content = "イラスト釣りゲーム"
					},
					new Description
					{
						Title = "Purpose",
						Content = "Android向けカジュアルゲームの配信"
					},
					new Description
					{
						Title = "My role",
						Content = "プログラム、イラスト"
					},
					new Description
					{
						Title = "Team size",
						Content = "3人"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = @"CSVファイルを用いたデータ管理により、イラスト情報（画像・名称・説明）を外部から編集可能な構成を実装"
					}
				},
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/RakugakiProjects_001.jpg",
                        Alt = "game",
                        Width = 1080,
                        Height = 1920,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/RakugakiProjects_002.jpg",
                        Alt = "game",
                        Width = 1080,
                        Height = 1920,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/RakugakiProjects_003.jpg",
                        Alt = "game",
                        Width = 1080,
                        Height = 1920,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/RakugakiProjects_004.jpg",
                        Alt = "game",
                        Width = 1080,
                        Height = 1920,
                        IsVideo = false
                    }
                },
                Technologies = new List<Technology>
                {
					new Technology{ Name = "Unity", Icon = "images/icon/Unity_Icon.svg"},
					new Technology{ Name = "C#", Icon = "images/icon/CSharp_Icon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
                },
				Links = new List<Link>
				{
					new Link
					{
						LinkUrl = "https://play.google.com/store/apps/details?id=com.Bottle70.RakugakiProjects&_gl=1*vq3bcr*_up*MQ..*_ga*MTk0MTI3OTUuMTc3NjMxODM2Nw..*_ga_6VGGZHMLM2*czE3NzYzMTgzNjYkbzEkZzAkdDE3NzYzMTgzNjYkajYwJGwwJGgw&hl=ja",
						LinkText = "Google Play Store",
						Target = "_blank"
					}
				},
                GithubLink = string.Empty,
            },
			new Project
            {
                ProjectName = "モササウルス育成ゲーム",
                Started = DateTime.Parse("2022-03"),
                Ended = DateTime.Parse("2022-03"),
				Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Content",
						Content = "放置育成ゲーム"
					},
					new Description
					{
						Title = "Purpose",
						Content = "Android向けハイパーカジュアルゲームの配信"
					},
					new Description
					{
						Title = "My role",
						Content = "プログラム"
					},
					new Description
					{
						Title = "Team size",
						Content = "2人"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = @"アセット管理とロード効率の向上のため、Unity Addressables を使用しました。
									収益化のため、Google AdMob を導入し、広告表示機能を実装しました。
									多言語対応のため、Unity Localization を使用し、言語切り替え機能を実装しました。"
					}
				},
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/Mosasaurus_001.png",
                        Alt = "main",
                        Width = 1920,
                        Height = 1080,
                        IsVideo = false
                    }
                },
                Technologies = new List<Technology>
				{
					new Technology{ Name = "Unity", Icon = "images/icon/Unity_Icon.svg"},
					new Technology{ Name = "C#", Icon = "images/icon/CSharp_Icon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
				},
				Links = new List<Link>
				{
					new Link
					{
						LinkUrl = "https://play.google.com/store/apps/details?id=com.Reverieate.Mos&hl=ja",
						LinkText = "Google Play Store",
						Target = "_blank"
					}
				},
				GithubLink = string.Empty,
			},
            new Project
            {
                ProjectName = "シューティングゲーム",
                Started = DateTime.Parse("2023-05-12"),
                Ended = DateTime.Parse("2023-05-22"),
				Descriptions = new List<Description>
				{
					new Description
					{
						Title = "Content",
						Content = "2Dシューティング"
					},
					new Description
					{
						Title = "Purpose",
						Content = "C++を用いたゲーム制作"
					},
					new Description
					{
						Title = "My role",
						Content = "プログラム"
					},
					new Description
					{
						Title = "Team size",
						Content = "1人"
					},
					new Description
					{
						Title = "Technical Highlights",
						Content = @"Siv3D・C++ を用いてゲームを開発し、描画・入力・サウンド処理を統合的に実装。
									ゲームループや衝突判定などの基礎ロジックを自作し、リアルタイム処理の理解を深めた。"
					}
				},
                Images = new List<ProImage>
                {
                    new ProImage
                    {
                        Src = "images/projects/STG_001.png",
                        Alt = "main",
                        Width = 405,
                        Height = 720,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/STG_002.png",
                        Alt = "main",
                        Width = 405,
                        Height = 720,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/STG_003.png",
                        Alt = "main",
                        Width = 405,
                        Height = 720,
                        IsVideo = false
                    },
                    new ProImage
                    {
                        Src = "images/projects/STG_004.png",
                        Alt = "main",
                        Width = 405,
                        Height = 720,
                        IsVideo = false
                    }
                },
                Technologies = new List<Technology>
				{
					new Technology{ Name = "Siv3D", Icon = "images/icon/Siv3D_Icon.svg"},
					new Technology{ Name = "C++", Icon = "images/icon/CPuls_ICon.svg"},
					new Technology{ Name = "VSCode", Icon = "images/icon/VSCode_Icon.svg"}
				},
				Links = new List<Link>
				{
					new Link
					{
						LinkText = "exeファイル",
						LinkUrl = "https://drive.google.com/file/d/1np0FFlSg3_ntw4f2RESh2kmu9qk1xwiq/view?usp=sharing",
						Target = "_blank"
					}
				},
				GithubLink = string.Empty,
			}
        };
    }
}
