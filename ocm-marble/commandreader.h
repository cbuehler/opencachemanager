#ifndef COMMANDREADER_H
#define COMMANDREADER_H

#include <QThread>
#include <marble/MarbleWidget.h>

class CommandReader : public QThread
{
    Q_OBJECT
public:
    CommandReader(Marble::MarbleWidget *marble);
    void run();
signals:
    void zoomTo(qreal, qreal);
private:
    Marble::MarbleWidget *m_marble;
};

#endif // COMMANDREADER_H
