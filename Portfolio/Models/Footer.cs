namespace Portfolio.Models;

public class Footer
{

}

public class Project
{
	public string ProjectName { get; set; }				// プロジェクト名
	public DateTime Started { get; set; }				// 開始日時
	public DateTime Ended { get; set; }					// 終了日時(Nullで進行形)
	public List<Description> Descriptions { get; set; }	// 概要
	public List<ProImage> Images { get; set; }			// 画像、動画
	public List<Technology> Technologies { get; set; }	// 技術(使用ツールや言語)
	public List<Link> Links { get; set; }				// 各種リンク
	public string GithubLink { get; set; }				// Githubのリンク(纏めてもいいかも)
}

public class Description
{
	public string Title { get; set; }					// タイトル
	public string Content { get; set; }					// 内容
}

public class Link
{    
	public string LinkUrl { get; set; }					// リンクのURL
	public string LinkText { get; set; }				// ボタンのテキスト
	public string Target { get; set; }					// ターゲット
}

public class Technology
{
    public string Name { get; set; }					// 技術名
    public string Icon { get; set; }					// アイコン
}

public class ProImage
{
    public string Src { get; set; }						// 画像や動画のリンク(動画の場合は埋め込みのリンク)
    public string Alt { get; set; }						// 
    public int Width { get; set; }						// 横幅
    public int Height { get; set; }						// 縦幅
    public bool IsVideo { get; set; }					// 動画かどうか
}

public interface IProjectServices
{
	List<Project> GetProjects();
}

public class NavItem
{
    public string Href { get; set; } = string.Empty;
    public string Title { get; set; }= string.Empty;
    public string Target { get; set; } = string.Empty;
}

public class FooterCategory
{
	public string Title { get; set; }
	public List<Link> Links { get; set; }
}