import Sitemapper from 'sitemapper';
const sitemapper = new Sitemapper();

const url = 'https://ninydev.com/sitemap_index.xml';

sitemapper.fetch(url)
    .then(({ url, sites }) => console.log(`url:${url}`, 'sites:', sites))
    .catch(error => console.log(error));
