select a.title, t.name 
from articles a left join article_tags at on a.article_id = at.article_id 
	join tags t on at.tag_id = t.tag_id