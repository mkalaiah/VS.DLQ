import { DLQTemplatePage } from './app.po';

describe('DLQ App', function() {
  let page: DLQTemplatePage;

  beforeEach(() => {
    page = new DLQTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
